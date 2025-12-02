using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedSettlementManager(ICacheManager cacheManager, ISettlementManager target)
    : ISettlementManager, ICachedGameDataManager
{
    public async Task<Settlement?> GetSettlementByIdAsync(Guid settlementId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetSettlementByIdAsync)}:{settlementId}",
            async () => await target.GetSettlementByIdAsync(settlementId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetSettlementsAsync)}:{request.SettlementId}:{request.Name}:{request.ParentId}",
            async () => await target.GetSettlementsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement settlement)
    {
        var result = await UpsertAsync(settlement, DatabaseConstants.SettlementCollection);
        return result;
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await DeleteAsync(settlementId, DatabaseConstants.SettlementCollection);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        Guid parentId,
        string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Settlement)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Settlement> UpsertAsync(Settlement entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync(
            $"{nameof(Settlement)}:{nameof(GetSettlementByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync(
            $"{nameof(Settlement)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}