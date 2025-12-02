namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface ICachedGameDataManager
{
    Task ClearCacheAsync(Guid entityId, string collectionName);
}