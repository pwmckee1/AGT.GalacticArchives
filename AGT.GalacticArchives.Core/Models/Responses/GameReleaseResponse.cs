namespace AGT.GalacticArchives.Core.Models.Responses;

public class GameReleaseResponse
{
    public Guid ReleaseId { get; set; }

    public string ReleaseName { get; set; } = null!;

    public string? ReleaseNumber { get; set; }
}