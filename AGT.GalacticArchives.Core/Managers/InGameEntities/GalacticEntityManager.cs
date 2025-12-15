using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameEntities;

public class GalacticEntityManager(
    IMapper mapper,
    IPlanetManager planetManager,
    IRegionManager regionManager,
    IStarSystemManager starSystemManager) : IGalacticEntityManager
{
    public async Task<Planet?> GetPlanetaryHierarchyAsync(Guid planetId)
    {
        var planetData = await planetManager.GetPlanetByIdAsync(planetId);

        var planet = mapper.Map<Planet>(planetData);

        if (planet == null)
        {
            return null;
        }

        planet.StarSystem = planet.StarSystemId.HasValue
            ? await GetStarSystemHierarchyAsync(planet.StarSystemId!.Value)
            : null;

        return planet;
    }

    public async Task<StarSystem?> GetStarSystemHierarchyAsync(Guid starSystemId)
    {
        var starSystemData = await starSystemManager.GetStarSystemByIdAsync(starSystemId);

        var starSystem = mapper.Map<StarSystem>(starSystemData);
        if (starSystem == null)
        {
            return null;
        }

        if (starSystem.Region == null)
        {
            var regionData = starSystem.RegionId.HasValue
                ? await regionManager.GetRegionByIdAsync(starSystem.RegionId!.Value)
                : null;

            if (regionData != null)
            {
                starSystem.Region = mapper.Map<Region>(regionData);
            }
        }

        return starSystem;
    }

    public async Task<Planet?> UpsertPlanetAsync(Planet? planet)
    {
        if (planet == null)
        {
            return planet;
        }

        var existingPlanet = await planetManager.GetPlanetByIdAsync(planet.PlanetId!.Value);
        if (existingPlanet!.ToDictionary().Matches(planet.ToDictionary()))
        {
            return existingPlanet;
        }

        return await planetManager.UpsertPlanetAsync(planet);
    }

    public async Task<StarSystem?> UpsertStarSystemAsync(StarSystem? starSystem)
    {
        if (starSystem == null)
        {
            return starSystem;
        }

        var existingStarSystem = await starSystemManager.GetStarSystemByIdAsync(starSystem.StarSystemId!.Value);
        if (existingStarSystem!.ToDictionary().Matches(starSystem.ToDictionary()))
        {
            return existingStarSystem;
        }

        return await starSystemManager.UpsertStarSystemAsync(starSystem);
    }

    public async Task<Region?> UpsertRegionAsync(Region? region)
    {
        if (region == null)
        {
            return region;
        }

        var existingRegion = await regionManager.GetRegionByIdAsync(region.RegionId!.Value);
        if (existingRegion!.ToDictionary().Matches(region.ToDictionary()))
        {
            return existingRegion;
        }

        return await regionManager.UpsertRegionAsync(region);
    }
}