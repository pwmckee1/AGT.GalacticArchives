using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedGalaxyManager(ICacheManager cacheManager, IGalaxyManager target) : IGalaxyManager, ICachedGameDataManager
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}",
            async () => await target.GetGalaxiesAsync(),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}:{request.GalaxyId}:{request.Name}:{request.ParentId}",
            async () => await target.GetGalaxiesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxyByIdAsync)}:{galaxyId}",
            async () => await target.GetGalaxyByIdAsync(galaxyId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        var result = await UpsertAsync(galaxy, DatabaseConstants.GalaxyCollection);
        return result;
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await DeleteAsync(galaxyId, DatabaseConstants.GalaxyCollection);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy> UpsertAsync(Galaxy entity, string collectionName)
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetGalaxyByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetAllAsync)}:{collectionName}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetByIdAsync)}:{entityId}");
    }
}
