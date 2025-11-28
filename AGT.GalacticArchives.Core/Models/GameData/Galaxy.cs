using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Galaxy : IGameData
{
    public Guid EntityId => GalaxyId;

    public Guid GalaxyId { get; set; } = Guid.NewGuid();

    public required int Sequence { get; set; }

    public required string Name { get; set; }

    public HashSet<Region> Regions { get; set; } = [];

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(GalaxyId), GalaxyId.ToString() },
            { nameof(Sequence), Sequence },
            { nameof(Name), Name },
        };
    }
}