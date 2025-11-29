using AGT.GalacticArchives.Configuration;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Extensions;
using AGT.GalacticArchives.Middleware;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper.EquivalencyExpression;
using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Caching.Distributed;

var builder = WebApplication.CreateBuilder(args);

var environment = builder.Environment;
var applicationSettings = new ApplicationSettings();
builder.Configuration.GetSection("ApplicationSettings").Bind(applicationSettings);
builder.Services.AddSingleton(applicationSettings);
ControllerConfiguration.AddControllers(builder.Services);

builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IDistributedCache, InMemoryDistributedCacheAdapter>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>((context, containerBuilder) =>
{
    containerBuilder.ConfigureDependencyInjection(applicationSettings, environment);
});

builder.Services.AddAutoMapper(cfg => cfg.AddCollectionMappers(), AppDomain.CurrentDomain.GetAssemblies());
builder.Services
    .AddControllers()
    .AddApplicationPart(typeof(Program).Assembly);
builder.Services.AddOpenApi();


builder.Services.AddSingleton(sp =>
{
    var logger = sp.GetRequiredService<ILogger<Program>>();

    var firestoreBuilder = new FirestoreDbBuilder
    {
        ProjectId = applicationSettings.Firebase.ProjectId,
    };

    if (environment.IsDevelopment())
    {
        // Check for emulator configuration
        var emulatorHost = Environment.GetEnvironmentVariable("FIRESTORE_EMULATOR_HOST");

        if (!string.IsNullOrEmpty(emulatorHost))
        {
            logger.LogInformation($"Using Firestore emulator at {emulatorHost}");
            firestoreBuilder.EmulatorDetection = EmulatorDetection.EmulatorOnly;
        }
        else
        {
            string? credentialsPath = applicationSettings.Firebase.CredentialsPath;
            if (string.IsNullOrEmpty(credentialsPath) || !File.Exists(credentialsPath))
            {
                throw new FileNotFoundException($"Firebase credentials not found at {credentialsPath}");
            }

            logger.LogInformation($"Loading Firebase credentials from file: {credentialsPath}");

            var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read);
            firestoreBuilder.Credential = CredentialFactory.FromStream<ServiceAccountCredential>(stream);
        }
    }
    else
    {
        var secret =
            GoogleSecretsConfiguration.GetSecret(applicationSettings.GoogleCloudProjectId!, "firebase-credentials");

        if (string.IsNullOrEmpty(secret))
        {
            throw new InvalidOperationException("Unable to retrieve firebase credentials");
        }

        firestoreBuilder.Credential = CredentialFactory.FromJson<ServiceAccountCredential>(secret);
    }

    return firestoreBuilder.Build();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMessageResponseMiddleware();
// app.UseMiddleware<RequestRewindMiddleware>();
app.UseExceptionHandler(options => { options.UseMiddleware<ErrorHandlingMiddleware>(); });
app.UseOptions();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();