using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

/// <summary>
/// A manager class that provides caching capabilities for star-system-related operations,
/// combining the functionalities of IStarSystemManager and IGameDataManager.
/// </summary>
public class CachedStarSystemManager(ICacheManager cacheManager, IStarSystemManager target) : IStarSystemManager
{
    /// <summary>
    /// Retrieves a star system by its unique identifier. If the star system exists in the cache, it will be
    /// returned from there, otherwise, it will fetch the data from the target source and cache it for future use.
    /// </summary>
    /// <param name="starSystemId">The unique identifier of the star system to retrieve.</param>
    /// <returns>
    /// A star system if found, or null if it does not exist.
    /// </returns>
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{nameof(GetStarSystemByIdAsync)}:{starSystemId}",
            async () => await target.GetStarSystemByIdAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem galaxy)
    {
        return await target.UpsertStarSystemAsync(galaxy);
    }

    public async Task DeleteStarSystemAsync(Guid galaxyId)
    {
        await target.DeleteStarSystemAsync(galaxyId);
    }

    // This is not being used by the Star System service but is part if the interface contract.
    // The idea being that we probably don't want to implement a "Get All" when it comes to star systems
    public Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves an entity by its unique identifier and the specified collection name.
    /// If the entity is found in the cache, it is returned from there, otherwise, it is
    /// fetched from the target source and cached for future use.
    /// </summary>
    /// <param name="entityId">The unique identifier of the entity to retrieve.</param>
    /// <param name="collectionName">The name of the collection where the entity is stored.</param>
    /// <returns>
    /// A dictionary representing the entity if found, or an empty dictionary if it does not exist.
    /// </returns>
    public async Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Dictionary<string, object>> GetByIdAsync(IGameData entity, string collectionName)
    {
        return await GetByIdAsync(entity.EntityId, collectionName);
    }

    public async Task<IGameData> UpsertAsync(IGameData entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{nameof(GetStarSystemByIdAsync)}:{entity.EntityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{nameof(GetByIdAsync)}:{entity.EntityId}:{collectionName}");
        return response;
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
    }
}