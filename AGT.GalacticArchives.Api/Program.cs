using AGT.GalacticArchives.Configuration;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Extensions;
using AGT.GalacticArchives.Middleware;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper.EquivalencyExpression;
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

    ServiceAccountCredential credentials;

    var secret =
        GoogleSecretsConfiguration.GetSecret(applicationSettings.GoogleCloudProjectId, "firebase-credentials");

    if (string.IsNullOrEmpty(secret))
    {
        throw new InvalidOperationException("Unable to retrieve firebase credentials");
    }

    credentials = CredentialFactory.FromJson<ServiceAccountCredential>(secret);

    // if (environment.IsDevelopment())
    // {
    //     string? credentialsPath = applicationSettings.Firebase.CredentialsPath;
    //
    //     if (string.IsNullOrEmpty(credentialsPath) || !File.Exists(credentialsPath))
    //     {
    //         throw new FileNotFoundException($"Firebase credentials not found at {credentialsPath}");
    //     }
    //
    //     logger.LogInformation($"Loading Firebase credentials from file: {credentialsPath}");
    //
    //     var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read);
    //     credentials = CredentialFactory.FromStream<ServiceAccountCredential>(stream);
    // }
    // else
    // {
    //     var secret =
    //         GoogleSecretsConfiguration.GetSecret(applicationSettings.GoogleCloudProjectId, "firebase-credentials");
    //
    //     if (string.IsNullOrEmpty(secret))
    //     {
    //         throw new InvalidOperationException("Unable to retrieve firebase credentials");
    //     }
    //
    //     credentials = CredentialFactory.FromJson<ServiceAccountCredential>(secret);
    // }

    return new FirestoreDbBuilder
    {
        ProjectId = applicationSettings.Firebase.ProjectId,
        Credential = credentials,
    }.Build();
});

var app = builder.Build();

// Test connection on startup (optional but useful)
// using (var scope = app.Services.CreateScope())
// {
//     var db = scope.ServiceProvider.GetRequiredService<FirestoreDb>();
//     var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
//
//     try
//     {
//         // Simple connection test
//         var testRef = db.Collection("_connection_test").Document("test");
//         await testRef.SetAsync(new Dictionary<string, object>
//         {
//             {"timestamp", FieldValue.ServerTimestamp},
//             {"message", "API started successfully"}
//         });
//         logger.LogInformation("✓ Firebase connection successful");
//     }
//     catch (Exception ex)
//     {
//         logger.LogError(ex, "✗ Firebase connection failed");
//         throw;
//     }
// }

// Configure the HTTP request pipeline.
app.UseMessageResponseMiddleware();
app.UseMiddleware<RequestRewindMiddleware>();
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