using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

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

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as RegionSearchRequest);
        string cacheKey = $"{nameof(Region)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> UpsertRegionAsync(Region request)
    {
        var result = await target.UpsertRegionAsync(request);
        await ClearCacheAsync(result.RegionId!.Value);
        await cacheManager.SetAsync($"{nameof(Region)}:{request.RegionId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<Region>> UpsertRegionAsync(HashSet<Region> request, CancellationToken ct)
    {
        var result = await target.UpsertRegionAsync(request, ct);
        var regionIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var regionId in regionIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Region)}:{regionId}");
        }

        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}s:");

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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}s:");
    }
}