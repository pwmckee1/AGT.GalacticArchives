namespace AGT.GalacticArchives.Core.Models.Responses;

public class GalaxyResponse
{
    public Guid GalaxyId { get; set; }

    public Guid EntityId { get; set; }

    public Guid ParentId { get; set; }

    public string CollectionName { get; set; } = null!;

    public string ParentCollectionName  { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string NormalizedName { get; set; } = null!;
}
