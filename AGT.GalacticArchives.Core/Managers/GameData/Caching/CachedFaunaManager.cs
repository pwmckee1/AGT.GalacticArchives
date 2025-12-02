using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedFaunaManager(ICacheManager cacheManager, IFaunaManager target) : IFaunaManager, ICachedGameDataManager
{
    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetFaunaByIdAsync)}:{faunaId}",
            async () => await target.GetFaunaByIdAsync(faunaId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetFaunaAsync)}:{request.FaunaId}:{request.Name}:{request.ParentId}",
            async () => await target.GetFaunaAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna fauna)
    {
        var result = await UpsertAsync(fauna, DatabaseConstants.FaunaCollection);
        return result;
    }

    public async Task<HashSet<DocumentSnapshot>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<DocumentSnapshot?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Fauna> UpsertAsync(Fauna entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await DeleteAsync(faunaId, DatabaseConstants.FaunaCollection);
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{nameof(GetFaunaByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}