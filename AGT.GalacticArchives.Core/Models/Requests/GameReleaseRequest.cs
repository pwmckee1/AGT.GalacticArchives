namespace AGT.GalacticArchives.Core.Models.Requests;

public class GameReleaseRequest
{
    public Guid? ReleaseId { get; set; }

    public string? ReleaseName { get; set; }

    public string? ReleaseNumber { get; set; }
}