using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.Environments;
using AGT.GalacticArchives.Core.Models.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class GalacticEntityManager(
    IGalaxyManager galaxyManager,
    IMapper mapper,
    IPlanetManager planetManager,
    IRegionManager regionManager,
    IStarSystemManager starSystemManager) : IGalacticEntityManager
{
    public async Task<Planet> GetPlanetaryHierarchyAsync(Guid planetId)
    {
        var planetData = await planetManager.GetPlanetByIdAsync(planetId);

        var planet = mapper.Map<Planet>(planetData);

        planet.StarSystem = await GetSolarHierarchyAsync(planet.StarSystemId);

        return planet;
    }

    public async Task<StarSystem> GetSolarHierarchyAsync(Guid starSystemId)
    {
        var starSystemData = await starSystemManager.GetStarSystemByIdAsync(starSystemId);

        var starSystem = mapper.Map<StarSystem>(starSystemData);

        starSystem.Region = await GetRegionalHierarchyAsync(starSystem.RegionId);

        return starSystem;
    }

    public async Task<Region> GetRegionalHierarchyAsync(Guid regionId)
    {
        var regionData = await regionManager.GetRegionByIdAsync(regionId);

        var region = mapper.Map<Region>(regionData);

        var galaxyData = await galaxyManager.GetGalaxyByIdAsync(region.GalaxyId);

        region.Galaxy = mapper.Map<Galaxy>(galaxyData);

        return region;
    }

    public async Task UpsertPlanetAsync(Planet? planet)
    {
        if (planet == null)
        {
            return;
        }

        var existingPlanet = await planetManager.GetPlanetByIdAsync(planet.PlanetId);
        if (existingPlanet!.ToDictionary().Matches(planet.ToDictionary()))
        {
            return;
        }

        await planetManager.UpsertPlanetAsync(planet);
    }

    public async Task UpsertStarSystemAsync(StarSystem? starSystem)
    {
        if (starSystem == null)
        {
            return;
        }

        var existingStarSystem = await starSystemManager.GetStarSystemByIdAsync(starSystem.StarSystemId);
        if (existingStarSystem!.ToDictionary().Matches(starSystem.ToDictionary()))
        {
            return;
        }

        await starSystemManager.UpsertStarSystemAsync(starSystem);
    }

    public async Task UpsertRegionAsync(Region? region)
    {
        if (region == null)
        {
            return;
        }

        var existingRegion = await regionManager.GetRegionByIdAsync(region.RegionId);
        if (existingRegion!.ToDictionary().Matches(region.ToDictionary()))
        {
            return;
        }

        await regionManager.UpsertRegionAsync(region);
    }
}