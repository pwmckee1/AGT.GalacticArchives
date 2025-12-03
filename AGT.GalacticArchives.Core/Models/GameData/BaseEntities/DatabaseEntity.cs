using AGT.GalacticArchives.Core.Models.GameData.Interfaces;

namespace AGT.GalacticArchives.Core.Models.GameData.BaseEntities;

public abstract class DatabaseEntity : IDatabaseEntity
{
    public virtual Guid EntityId { get; set; }

    public virtual Guid ParentId { get; set; }

    public virtual string CollectionName => null!;

    public virtual string ParentCollectionName => null!;

    public virtual required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();
}