using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedFaunaManager(ICacheManager cacheManager, IFaunaManager target)
    : IFaunaManager, ICachedGameDataManager
{
    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{faunaId}",
            async () => await target.GetFaunaByIdAsync(faunaId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as FaunaSearchRequest);
        string cacheKey = $"{nameof(Fauna)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna request)
    {
        await cacheManager.ClearCacheByKeyAsync($"{nameof(Fauna)}:{request.FaunaId}");
        var result = await target.UpsertFaunaAsync(request);
        await cacheManager.SetAsync($"{nameof(Fauna)}:{request.FaunaId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<Fauna>> UpsertFaunaAsync(HashSet<Fauna> request, CancellationToken ct)
    {
        var result = await target.UpsertFaunaAsync(request, ct);
        var faunaIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var faunaId in faunaIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Fauna)}:{faunaId}");
        }

        return result;
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await target.DeleteFaunaAsync(faunaId);
        await ClearCacheAsync(faunaId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{BusinessRuleConstants.AllCacheKey}");
    }
}