using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var logger = sp.GetRequiredService<ILogger<Program>>();
    var env = sp.GetRequiredService<IWebHostEnvironment>();

    ServiceAccountCredential credentials;
    var projectId = configuration["Firebase:ProjectId"];

    if (env.IsDevelopment())
    {
        var credentialsPath = configuration["Firebase:CredentialsPath"];

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
        ProjectId = projectId,
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