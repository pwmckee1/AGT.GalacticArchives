namespace AGT.GalacticArchives.Core.Models.Requests;

public class DatabaseEntityRequest
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public int? DocumentSequence { get; set; }
}