using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Managers.Entities.Caching;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;

namespace AGT.GalacticArchives.Core.Managers.Environments.Caching;

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
            $"{nameof(Region)}:{request.RegionId}",
            async () => await target.GetRegionsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> UpsertRegionAsync(Region request)
    {
        var result = await target.UpsertRegionAsync(request);
        await cacheManager.SetAsync($"{nameof(Region)}:{request.RegionId}", result, BusinessRuleConstants.DayInMinutes);
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