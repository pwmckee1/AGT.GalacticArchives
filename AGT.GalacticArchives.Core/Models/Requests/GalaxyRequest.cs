namespace AGT.GalacticArchives.Core.Models.Requests;

public class GalaxyRequest : GameDataRequest
{
    public Guid? GalaxyId { get; set; }

    public string? Name { get; set; }

    public int? Sequence { get; set; }

    public string? CollectionName { get; set; }

    public string? ParentCollectionName { get; set; }

    public string? NormalizedName { get; set; }
}
