namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface ICachedGameDataManager
{
    Task ClearCacheAsync(Guid entityId);
}