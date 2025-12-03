namespace AGT.GalacticArchives.Core.Models.GameData.Interfaces;

public interface IDatabaseEntity
{
    Guid EntityId { get; }

    Guid ParentId { get; set; }

    string CollectionName { get; }

    string ParentCollectionName { get; }

    string Name { get; set; }

    string NormalizedName { get; }
}