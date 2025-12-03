namespace AGT.GalacticArchives.Core.Managers.Entities.Caching;

public interface ICachedGameDataManager
{
    Task ClearCacheAsync(Guid entityId);
}