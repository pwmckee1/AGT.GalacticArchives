using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedGalaxyManager(ICacheManager cacheManager, IGalaxyManager target) : IGalaxyManager
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}",
            async () => await target.GetGalaxiesAsync(),
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
        return await target.UpsertGalaxyAsync(galaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await target.DeleteGalaxyAsync(galaxyId);
    }

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>> GetByIdAsync(IGameData entity, string collectionName)
    {
        return await GetByIdAsync(entity, collectionName);
    }

    public async Task<IGameData> UpsertAsync(IGameData entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetGalaxyByIdAsync)}:{entity.EntityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetAllAsync)}:{collectionName}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{nameof(GetByIdAsync)}:{entity.EntityId}:{collectionName}");
        return response;
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
    }
}