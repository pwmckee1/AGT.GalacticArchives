namespace AGT.GalacticArchives.Core.Models.Responses;

public class GameReleaseResponse : DatabaseEntityResponse
{
    public Guid? GameReleaseId { get => field ?? EntityId; set; }

    public string? ReleaseNumber { get; set; }
}