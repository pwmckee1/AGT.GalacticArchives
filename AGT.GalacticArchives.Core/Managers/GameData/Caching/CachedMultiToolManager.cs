using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedMultiToolManager(ICacheManager cacheManager, IMultiToolManager target)
    : IMultiToolManager, ICachedGameDataManager
{
    public async Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{nameof(GetMultiToolByIdAsync)}:{multiToolId}",
            async () => await target.GetMultiToolByIdAsync(multiToolId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{nameof(GetMultiToolsAsync)}:{request.EntityId}:{request.Name}:{request.ParentId}",
            async () => await target.GetMultiToolsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool multiTool)
    {
        var result = await UpsertAsync(multiTool, DatabaseConstants.MultiToolCollection);
        return result;
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await DeleteAsync(multiToolId, DatabaseConstants.MultiToolCollection);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
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
            $"{nameof(MultiTool)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<MultiTool> UpsertAsync(MultiTool entity, string collectionName)
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(MultiTool)}:{nameof(GetMultiToolByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync(
            $"{nameof(MultiTool)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}