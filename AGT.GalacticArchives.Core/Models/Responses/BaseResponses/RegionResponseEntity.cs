namespace AGT.GalacticArchives.Core.Models.Responses.BaseResponses;

public class RegionResponseEntity : GalaxyResponseEntity
{
    public required Guid RegionId { get; set; }

    public required RegionResponse Region { get; set; }
}