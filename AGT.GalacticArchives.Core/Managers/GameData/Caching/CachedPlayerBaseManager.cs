using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedPlayerBaseManager(ICacheManager cacheManager, IPlayerBaseManager target) : IPlayerBaseManager, ICachedGameDataManager
{
    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetPlayerBaseByIdAsync)}:{playerBaseId}",
            async () => await target.GetPlayerBaseByIdAsync(playerBaseId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetPlayerBasesAsync)}:{request.PlayerBaseId}:{request.Name}:{request.ParentId}",
            async () => await target.GetPlayerBasesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase playerBase)
    {
        var result = await UpsertAsync(playerBase, DatabaseConstants.PlayerBaseCollection);
        return result;
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await DeleteAsync(playerBaseId, DatabaseConstants.PlayerBaseCollection);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PlayerBase> UpsertAsync(PlayerBase entity, string collectionName)
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PlayerBase)}:{nameof(GetPlayerBaseByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PlayerBase)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}
