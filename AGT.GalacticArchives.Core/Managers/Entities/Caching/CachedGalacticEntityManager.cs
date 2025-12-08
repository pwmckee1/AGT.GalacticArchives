using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities.Caching;

public class CachedGalacticEntityManager(ICacheManager cacheManager, IGalacticEntityManager target)
    : IGalacticEntityManager, ICachedGameDataManager
{
    public async Task<Planet> GetPlanetaryHierarchyAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{planetId}",
            async () => await target.GetPlanetaryHierarchyAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> GetStarSystemHierarchyAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{starSystemId}",
            async () => await target.GetStarSystemHierarchyAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task UpsertPlanetAsync(Planet? planet)
    {
        await target.UpsertPlanetAsync(planet);
        await cacheManager.SetAsync($"{nameof(Planet)}:{planet!.PlanetId}", planet, BusinessRuleConstants.DayInMinutes);
    }

    public async Task UpsertStarSystemAsync(StarSystem? starSystem)
    {
        await target.UpsertStarSystemAsync(starSystem);
        await cacheManager.SetAsync($"{nameof(StarSystem)}:{starSystem!.StarSystemId}", starSystem, BusinessRuleConstants.DayInMinutes);
    }

    public async Task UpsertRegionAsync(Region? region)
    {
        await target.UpsertRegionAsync(region);
        await cacheManager.SetAsync($"{nameof(Region)}:{region!.RegionId}", region, BusinessRuleConstants.DayInMinutes);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Region)}:{entityId}");
    }
}