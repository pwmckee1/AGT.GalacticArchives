namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface IDatabaseEntityResponse
{
    Guid? EntityId { get; set; }

    string? Name { get; set; }

    string? NormalizedName { get; set; }

    int? DocumentSequence { get; set; }
}