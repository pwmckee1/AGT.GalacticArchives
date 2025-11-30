using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedStarSystemManager(ICacheManager cacheManager, IStarSystemManager target) : IStarSystemManager, ICachedGameDataManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{nameof(GetStarSystemByIdAsync)}:{starSystemId}",
            async () => await target.GetStarSystemByIdAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object?>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var result = await UpsertAsync(starSystem, DatabaseConstants.RegionCollection);
        return (StarSystem)result;
    }

    public async Task<IGameData> UpsertAsync(IGameData entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await DeleteAsync(starSystemId, DatabaseConstants.StarSystemCollection);
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{nameof(GetStarSystemByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }

    // This is not being used by the Star System service but is part if the interface contract.
    // The idea being that we probably don't want to implement a "Get All" when it comes to star systems
    public Task<HashSet<Dictionary<string, object?>>> GetAllAsync(string collectionName)
    {
        throw new NotImplementedException();
    }
}