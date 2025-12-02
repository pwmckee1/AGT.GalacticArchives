using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedPlanetManager(ICacheManager cacheManager, IPlanetManager target) : IPlanetManager, ICachedGameDataManager
{
    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetPlanetByIdAsync)}:{planetId}",
            async () => await target.GetPlanetByIdAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetPlanetsAsync)}:{request.PlanetId}:{request.Name}:{request.ParentId}",
            async () => await target.GetPlanetsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Planet> UpsertPlanetAsync(Planet planet)
    {
        var result = await UpsertAsync(planet, DatabaseConstants.PlanetCollection);
        return result;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Planet> UpsertAsync(Planet entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await DeleteAsync(planetId, DatabaseConstants.PlanetCollection);
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{nameof(GetPlanetByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}
