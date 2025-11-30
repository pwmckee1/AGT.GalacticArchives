namespace AGT.GalacticArchives.Core.Interfaces.Caching;

public interface ICachedGameDataManager
{
    Task ClearCacheAsync(Guid entityId, string collectionName);
}