using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.GameEntities;

public class PointOfInterest : DatabaseGameEntity
{
    public Guid PointOfInterestId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PointOfInterestId;

    public LocationTypes? LocationType { get; set; }
}