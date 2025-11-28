using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Galaxy : IGameData
{
    public Guid EntityId => GalaxyId;

    public required Guid GalaxyId
    {
        get => field == Guid.Empty ? Guid.NewGuid() : field;
        set;
    }

    public required int Sequence { get; set; }

    public required string Name { get; set; }

    public HashSet<Region> Regions { get; set; } = [];

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(GalaxyId), GalaxyId },
            { nameof(Sequence), Sequence },
            { nameof(Name), Name },
        };
    }
}