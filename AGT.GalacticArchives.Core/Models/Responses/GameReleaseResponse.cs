namespace AGT.GalacticArchives.Core.Models.Responses;

public class GameReleaseResponse : DatabaseEntityResponse
{
    public Guid? ReleaseId { get => field ?? EntityId; set; }

    public string? ReleaseName { get => field ?? Name; set; }

    public string? ReleaseNumber { get; set; }
}