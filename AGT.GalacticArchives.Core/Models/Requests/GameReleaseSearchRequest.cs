namespace AGT.GalacticArchives.Core.Models.Requests;

public class GameReleaseSearchRequest : BaseSearchRequest
{
    public Guid? GameReleaseId { get; set; }

    public string? Name { get; set; }

    public string? ReleaseNumber { get; set; }
}