using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedGalacticEntityManager(ICacheManager cacheManager, IGalacticEntityManager target)
    : IGalacticEntityManager, ICachedGameDataManager
{
    public async Task<Planet?> GetPlanetaryHierarchyAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{planetId}",
            async () => await target.GetPlanetaryHierarchyAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem?> GetStarSystemHierarchyAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{starSystemId}",
            async () => await target.GetStarSystemHierarchyAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Planet?> UpsertPlanetAsync(Planet? planet)
    {
        var updatedPlanet = await target.UpsertPlanetAsync(planet);
        await cacheManager.SetAsync(
            $"{nameof(Planet)}:{updatedPlanet!.PlanetId}",
            updatedPlanet,
            BusinessRuleConstants.DayInMinutes);
        return updatedPlanet;
    }

    public async Task<StarSystem?> UpsertStarSystemAsync(StarSystem? starSystem)
    {
        await cacheManager.ClearCacheByKeyAsync($"{nameof(StarSystem)}:{starSystem?.StarSystemId}");
        var updatedStarSystem = await target.UpsertStarSystemAsync(starSystem);
        await cacheManager.SetAsync(
            $"{nameof(StarSystem)}:{updatedStarSystem!.StarSystemId}",
            updatedStarSystem,
            BusinessRuleConstants.DayInMinutes);
        return updatedStarSystem;
    }

    public async Task<Region?> UpsertRegionAsync(Region? region)
    {
        var updatedRegion = await target.UpsertRegionAsync(region);
        await cacheManager.SetAsync(
            $"{nameof(Region)}:{updatedRegion!.RegionId}",
            updatedRegion,
            BusinessRuleConstants.DayInMinutes);
        return updatedRegion;
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}:{entityId}");
    }
}