namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

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

    public async Task<Settlement> UpsertSettlementAsync(Settlement settlement)
    {
        var result = await target.UpsertSettlementAsync(settlement);
        await cacheManager.SetAsync($"{nameof(Settlement)}:{settlement.EntityId}", result, BusinessRuleConstants.DayInMinutes);
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