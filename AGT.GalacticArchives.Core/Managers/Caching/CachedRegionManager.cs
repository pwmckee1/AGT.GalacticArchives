using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.Caching;

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
        string cacheKey = request.RegionId.HasValue ? $"{nameof(Region)}:{request.RegionId}" : $"{nameof(Region)}s";
        var result = await cacheManager.GetAsync(
            cacheKey,
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

    public async Task<HashSet<Region>> UpsertRegionAsync(HashSet<Region> request)
    {
        var result = await target.UpsertRegionAsync(request);
        await cacheManager.SetAsync($"{nameof(Region)}s", result, BusinessRuleConstants.DayInMinutes);
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}s");
    }
}