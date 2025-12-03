using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedRegionManager(ICacheManager cacheManager, IRegionManager target)
    : IRegionManager, ICachedGameDataManager
{
    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{regionId}",
            async () => await target.GetRegionByIdAsync(regionId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Region>> GetRegionsAsync(RegionRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{request.EntityId}",
            async () => await target.GetRegionsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> UpsertRegionAsync(Region region)
    {
        var result = await target.UpsertRegionAsync(region);
        await cacheManager.SetAsync($"{nameof(Region)}:{region.EntityId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await target.DeleteRegionAsync(regionId);
        await ClearCacheAsync(regionId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}:{entityId}");
    }
}