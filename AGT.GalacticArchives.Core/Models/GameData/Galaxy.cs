using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Galaxy : DatabaseEntity
{
    public override Guid EntityId => GalaxyId;

    public override Guid ParentId => GalaxyId;

    public override string CollectionName => DatabaseConstants.GalaxyCollection;

    public override string ParentCollectionName => DatabaseConstants.GalaxyCollection;

    public Guid GalaxyId { get; set; } = Guid.NewGuid();

    public required int Sequence { get; set; }

    public HashSet<Region> Regions { get; set; } = [];
}