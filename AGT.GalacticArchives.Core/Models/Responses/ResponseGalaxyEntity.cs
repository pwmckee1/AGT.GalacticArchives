namespace AGT.GalacticArchives.Core.Models.Responses;

public class ResponseGalaxyEntity : ResponseGameDataEntity
{
    public required Guid GalaxyId { get; set; }

    public required GalaxyResponse Galaxy { get; set; }
}