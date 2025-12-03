namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class RequestGameDataEntity
{
    public Guid? EntityId { get; set; }

    public string? Name { get; set; }

    public string? CollectionName { get; set; }

    public Guid? ParentId { get; set; }
}