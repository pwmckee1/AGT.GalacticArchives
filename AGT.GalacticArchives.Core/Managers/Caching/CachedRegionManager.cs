using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedRegionManager(ICacheManager cacheManager, IRegionManager target) : IRegionManager, ICachedGameDataManager
{
    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{nameof(GetRegionByIdAsync)}:{regionId}",
            async () => await target.GetRegionByIdAsync(regionId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object?>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> UpsertRegionAsync(Region region)
    {
        var result = await UpsertAsync(region, DatabaseConstants.RegionCollection);
        return (Region)result;
    }

    public async Task<IGameData> UpsertAsync(IGameData entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await DeleteAsync(regionId, DatabaseConstants.RegionCollection);
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}:{nameof(GetRegionByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }

    // This is not being used by the Region service but is part if the interface contract.
    // The idea being that we probably don't want to implement a "Get All" when it comes to regions
    public Task<HashSet<Dictionary<string, object?>>> GetAllAsync(string collectionName)
    {
        throw new NotImplementedException();
    }
}