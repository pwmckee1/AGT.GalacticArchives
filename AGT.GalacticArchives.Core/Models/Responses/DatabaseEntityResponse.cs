using AGT.GalacticArchives.Core.Interfaces.Models;

namespace AGT.GalacticArchives.Core.Models.Responses;

public class DatabaseEntityResponse : IDatabaseEntityResponse
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public int? DocumentSequence { get; set; }
}