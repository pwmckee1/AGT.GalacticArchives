using AGT.GalacticArchives.Core.Interfaces.Models;

namespace AGT.GalacticArchives.Core.Models.Database;

public abstract class DatabaseEntity : IDatabaseEntity
{
    public abstract Guid EntityId { get; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Read-only property. Returns Name in uppercase
    /// </summary>
    public string NormalizedName => Name.ToUpperInvariant();

    public int? DocumentSequence { get; set; }
}