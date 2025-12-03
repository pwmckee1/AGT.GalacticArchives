namespace AGT.GalacticArchives.Core.Models.Application;

using AGT.GalacticArchives.Core.Models.AppSettings;

public class ApplicationSettings
{
    public string[] AllowedOrigins { get; set; } = [];

    public FirebaseSettings Firebase { get; set; } = new();

    public bool EnableDeveloperErrors { get; set; }

    public string? GoogleCloudProjectId { get; set; }
}