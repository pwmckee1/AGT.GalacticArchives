namespace AGT.GalacticArchives.Core.Models.GameData;

using System.Reflection;
using AGT.GalacticArchives.Core.Constants;

public class Galaxy : GameDataEntity
{
    public override Guid EntityId => GalaxyId;

    public override Guid ParentId => GalaxyId;

    public override string CollectionName => DatabaseConstants.GalaxyCollection;

    public override string ParentCollectionName => DatabaseConstants.GalaxyCollection;

    public Guid GalaxyId { get; set; } = Guid.NewGuid();

    public required int Sequence { get; set; }

    public HashSet<Region> Regions { get; set; } = [];

    public override Dictionary<string, object?> ToDictionary(
        GameDataEntity? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Galaxy).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(Regions),
            nameof(CollectionName),
            nameof(ParentCollectionName),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}