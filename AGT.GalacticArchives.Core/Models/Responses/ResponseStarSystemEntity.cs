namespace AGT.GalacticArchives.Core.Models.Responses;

public class ResponseStarSystemEntity : ResponseRegionEntity
{
    public required Guid StarSystemId { get; set; }

    public required StarSystemResponse StarSystem { get; set; }
}