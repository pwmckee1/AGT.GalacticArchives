using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Release : IGameData
{
    public Guid EntityId => ReleaseId;

    public Guid ReleaseId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public required string? ReleaseNumber { get; set; }

    public required string? ReleaseDate { get; set; }

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(ReleaseId), ReleaseId },
            { nameof(Name), Name },
            { nameof(ReleaseNumber), ReleaseNumber },
            { nameof(ReleaseDate), ReleaseDate },
        };
    }
}