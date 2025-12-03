using AGT.GalacticArchives.Core.Managers.Environments;
using AGT.GalacticArchives.Core.Models.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class EntityHierarchyManager(
    IGalaxyManager galaxyManager,
    IMapper mapper,
    IPlanetManager planetManager,
    IRegionManager regionManager,
    IStarSystemManager starSystemManager) : IEntityHierarchyManager
{
    public async Task<Planet> GetPlanetWithHierarchyAsync(Guid planetId)
    {
        var planetData = await planetManager.GetPlanetByIdAsync(planetId);

        var planet = mapper.Map<Planet>(planetData);

        planet.StarSystem = await GetStarSystemWithHierarchyAsync(planet.StarSystemId);

        return planet;
    }

    public async Task<StarSystem> GetStarSystemWithHierarchyAsync(Guid starSystemId)
    {
        var starSystemData = await starSystemManager.GetStarSystemByIdAsync(starSystemId);

        var starSystem = mapper.Map<StarSystem>(starSystemData);

        starSystem.Region = await GetRegionWithHierarchyAsync(starSystem.RegionId);

        return starSystem;
    }

    public async Task<Region> GetRegionWithHierarchyAsync(Guid regionId)
    {
        var regionData = await regionManager.GetRegionByIdAsync(regionId);

        var region = mapper.Map<Region>(regionData);

        var galaxyData = await galaxyManager.GetGalaxyByIdAsync(region.GalaxyId);

        region.Galaxy = mapper.Map<Galaxy>(galaxyData);

        return region;
    }
}