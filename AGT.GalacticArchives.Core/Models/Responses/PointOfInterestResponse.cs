using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class PointOfInterestResponse : GameEntityResponse
{
    public string? PointOfInterestName { get; set; }

    public LocationTypes? LocationType { get; set; }
}