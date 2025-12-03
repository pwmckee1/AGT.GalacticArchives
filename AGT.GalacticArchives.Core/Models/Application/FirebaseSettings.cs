namespace AGT.GalacticArchives.Core.Models.Application;

public class FirebaseSettings
{
    public string? CredentialsPath { get; set; }

    public string? ProjectId { get; set; }

    public string SecretsId { get; set; } = null!;
}