using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedStarSystemManager(ICacheManager cacheManager, IStarSystemManager target)
    : IStarSystemManager, ICachedGameDataManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{starSystemId}",
            async () => await target.GetStarSystemByIdAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as StarSystemSearchRequest);
        string cacheKey = $"{nameof(StarSystem)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var result = await target.UpsertStarSystemAsync(starSystem);
        await cacheManager.SetAsync(
            $"{nameof(StarSystem)}:{starSystem.StarSystemId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<StarSystem>> UpsertStarSystemAsync(HashSet<StarSystem> request, CancellationToken ct)
    {
        var result = await target.UpsertStarSystemAsync(request, ct);
        var starSystemIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var starSystemId in starSystemIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(StarSystem)}:{starSystemId}");
        }

        return result;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await target.DeleteStarSystemAsync(starSystemId);
        await ClearCacheAsync(starSystemId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{BusinessRuleConstants.AllCacheKey}");
    }
}