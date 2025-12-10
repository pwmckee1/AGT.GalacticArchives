using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class PointOfInterest : DatabaseGameEntity
{
    public Guid PointOfInterestId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PointOfInterestId;

    public LocationTypes? Type { get; set; }
}