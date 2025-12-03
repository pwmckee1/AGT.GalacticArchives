using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.Environments;

namespace AGT.GalacticArchives.Core.Managers.Entities.Caching;

public class CachedInnerSystemEntityManager(ICacheManager cacheManager, IEntityHierarchyManager target)
    : IEntityHierarchyManager, ICachedGameDataManager
{
    public async Task<Planet> GetPlanetWithHierarchyAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{planetId}",
            async () => await target.GetPlanetWithHierarchyAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> GetStarSystemWithHierarchyAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{starSystemId}",
            async () => await target.GetStarSystemWithHierarchyAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Region> GetRegionWithHierarchyAsync(Guid regionId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Region)}:{regionId}",
            async () => await target.GetRegionWithHierarchyAsync(regionId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(EntityHierarchyManager)}:{entityId}");
    }
}