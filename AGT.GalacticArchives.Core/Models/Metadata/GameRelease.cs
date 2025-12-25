using AGT.GalacticArchives.Core.Models.Database;

namespace AGT.GalacticArchives.Core.Models.Metadata;

public class GameRelease : DatabaseEntity
{
    public Guid GameReleaseId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => GameReleaseId;

    public string? ReleaseNumber { get; set; }
}