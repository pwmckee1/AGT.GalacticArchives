using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedStarshipManager(ICacheManager cacheManager, IStarshipManager target) : IStarshipManager, ICachedGameDataManager
{
    public async Task<Starship?> GetStarshipByIdAsync(Guid starshipId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetStarshipByIdAsync)}:{starshipId}",
            async () => await target.GetStarshipByIdAsync(starshipId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetStarshipsAsync)}:{request.StarshipId}:{request.Name}:{request.ParentId}",
            async () => await target.GetStarshipsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Starship> UpsertStarshipAsync(Starship starship)
    {
        var result = await UpsertAsync(starship, DatabaseConstants.StarshipCollection);
        return result;
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await DeleteAsync(starshipId, DatabaseConstants.StarshipCollection);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Starship> UpsertAsync(Starship entity, string collectionName)
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Starship)}:{nameof(GetStarshipByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Starship)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}
