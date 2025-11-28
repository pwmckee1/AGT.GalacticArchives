namespace AGT.GalacticArchives.Core.Models.AppSettings;

public class ApplicationSettings
{
    public string[] AllowedOrigins { get; set; } = null!;

    public FirebaseSettings Firebase { get; set; } = new();
}