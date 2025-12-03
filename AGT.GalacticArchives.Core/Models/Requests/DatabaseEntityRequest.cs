namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class DatabaseEntityRequest
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public string? CollectionName { get; set; }

    public string? ParentCollectionName { get; set; }

    public Guid? ParentId { get; set; }
}