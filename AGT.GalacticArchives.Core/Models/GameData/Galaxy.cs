using System.Reflection;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Galaxy : GameData
{
    public override Guid EntityId => GalaxyId;

    public Guid GalaxyId { get; set; } = Guid.NewGuid();

    public required int Sequence { get; set; }

    public HashSet<Region> Regions { get; set; } = [];

    public override Dictionary<string, object?> ToDictionary(
        GameData gameData = null!,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Galaxy).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(Regions),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}