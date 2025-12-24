using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PointOfInterestRequest : GameEntityRequest
{
    public Guid? PointOfInterestId { get; set; }

    public LocationTypes? LocationType { get; set; }
}