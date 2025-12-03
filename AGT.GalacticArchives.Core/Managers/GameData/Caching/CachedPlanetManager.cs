using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedPlanetManager(ICacheManager cacheManager, IPlanetManager target)
    : IPlanetManager, ICachedGameDataManager
{
    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{planetId}",
            async () => await target.GetPlanetByIdAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{request.EntityId}",
            async () => await target.GetPlanetsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Planet> UpsertPlanetAsync(Planet planet)
    {
        var result = await target.UpsertPlanetAsync(planet);
        await cacheManager.SetAsync($"{nameof(Planet)}:{planet.EntityId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await target.DeletePlanetAsync(planetId);
        await ClearCacheAsync(planetId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{entityId}");
    }
}