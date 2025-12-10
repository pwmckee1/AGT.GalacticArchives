using AGT.GalacticArchives.Core.Models.Database;

namespace AGT.GalacticArchives.Core.Models.GameMetaData;

public class GameRelease : DatabaseEntity
{
    public override Guid EntityId { get; } = Guid.NewGuid();

    public string? ReleaseNumber { get; set; }
}