namespace AGT.GalacticArchives.Core.Models.Responses;

public class ResponseRegionEntity : ResponseGalaxyEntity
{
    public required Guid RegionId { get; set; }

    public required RegionResponse Region { get; set; }
}