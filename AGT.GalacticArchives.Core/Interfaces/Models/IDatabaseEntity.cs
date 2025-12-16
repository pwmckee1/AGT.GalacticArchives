namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface IDatabaseEntity
{
    Guid EntityId { get; }

    string Name { get; set; }

    string? NormalizedName { get; }

    int? DocumentSequence { get; set; }
}