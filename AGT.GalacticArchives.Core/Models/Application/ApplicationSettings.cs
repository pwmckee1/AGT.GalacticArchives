using AGT.GalacticArchives.Core.Models.AppSettings;

namespace AGT.GalacticArchives.Core.Models.Application;

public class ApplicationSettings
{
    public string[] AllowedOrigins { get; set; } = [];

    public FirebaseSettings Firebase { get; set; } = new();
    public bool EnableDeveloperErrors { get; set; }
    public string? GoogleCloudProjectId { get; set; }
}