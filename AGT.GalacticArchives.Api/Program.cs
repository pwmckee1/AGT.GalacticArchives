using AGT.GalacticArchives.Configuration;
using AGT.GalacticArchives.Core.Models.AppSettings;
using AutoMapper.EquivalencyExpression;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

var builder = WebApplication.CreateBuilder(args);

var environment = builder.Environment;
var applicationSettings = new ApplicationSettings();
builder.Configuration.GetSection("ApplicationSettings").Bind(applicationSettings);

builder.ConfigureDependencyInjection(applicationSettings, environment);

builder.Services.AddAutoMapper(cfg => cfg.AddCollectionMappers(), AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddOpenApi();


builder.Services.AddSingleton(sp =>
{
    var logger = sp.GetRequiredService<ILogger<Program>>();

    ServiceAccountCredential credentials;

    if (environment.IsDevelopment())
    {
        string? credentialsPath = applicationSettings.Firebase.CredentialsPath;

        if (string.IsNullOrEmpty(credentialsPath) || !File.Exists(credentialsPath))
        {
            throw new FileNotFoundException($"Firebase credentials not found at {credentialsPath}");
        }

        logger.LogInformation($"Loading Firebase credentials from file: {credentialsPath}");

        var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read);
        credentials = CredentialFactory.FromStream<ServiceAccountCredential>(stream);
    }
    else
    {
        var credentialsJson = Environment.GetEnvironmentVariable("FIREBASE_CREDENTIALS");

        if (string.IsNullOrEmpty(credentialsJson))
        {
            throw new InvalidOperationException("FIREBASE_CREDENTIALS environment variable not set");
        }

        credentials = CredentialFactory.FromJson<ServiceAccountCredential>(credentialsJson);
    }

    return new FirestoreDbBuilder
    {
        ProjectId = applicationSettings.Firebase.ProjectId,
        Credential = credentials,
    }.Build();
});

var app = builder.Build();

// Test connection on startup (optional but useful)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<FirestoreDb>();
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

    try
    {
        // Simple connection test
        var testRef = db.Collection("_connection_test").Document("test");
        await testRef.SetAsync(new Dictionary<string, object>
        {
            {"timestamp", FieldValue.ServerTimestamp},
            {"message", "API started successfully"}
        });
        logger.LogInformation("✓ Firebase connection successful");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "✗ Firebase connection failed");
        throw;
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();