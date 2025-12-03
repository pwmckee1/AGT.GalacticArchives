using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

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

    public async Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{request.EntityId}",
            async () => await target.GetSettlementsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement request)
    {
        var result = await target.UpsertSettlementAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(Settlement)}:{request.EntityId}",
            result,
            BusinessRuleConstants.DayInMinutes);
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
    }
}