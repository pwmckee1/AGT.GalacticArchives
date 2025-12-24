using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PointOfInterestSearchRequest : GameEntitySearchRequest
{
    public Guid? PointOfInterestId { get; set; }

    public LocationTypes? LocationType { get; set; }
}