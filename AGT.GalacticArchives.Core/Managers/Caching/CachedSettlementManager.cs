using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedSettlementManager(ICacheManager cacheManager, ISettlementManager target)
    : ISettlementManager, ICachedGameDataManager
{
    public async Task<Settlement?> GetSettlementByIdAsync(Guid settlementId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{settlementId}",
            async () => await target.GetSettlementByIdAsync(settlementId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as SettlementSearchRequest);
        string cacheKey = $"{nameof(Settlement)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement request)
    {
        var result = await target.UpsertSettlementAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(Settlement)}:{request.SettlementId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<Settlement>> UpsertSettlementAsync(HashSet<Settlement> request, CancellationToken ct)
    {
        var result = await target.UpsertSettlementAsync(request, ct);
        var settlementIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var settlementId in settlementIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Settlement)}:{settlementId}");
        }

        return result;
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await target.DeleteSettlementAsync(settlementId);
        await ClearCacheAsync(settlementId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Settlement)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Settlement)}:{BusinessRuleConstants.AllCacheKey}");
    }
}