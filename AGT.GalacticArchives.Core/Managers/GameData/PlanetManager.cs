using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PlanetManager(IFirestoreManager firestoreManager, IMapper mapper) : IPlanetManager
{
    private const string Collection = DatabaseConstants.PlanetCollection;

    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        var planetDoc = await firestoreManager.GetByIdAsync(planetId, Collection);
        var planet = planetDoc != null ? mapper.Map<Planet>(planetDoc) : null;

        if (planet == null)
        {
            return null;
        }

        await SetPlanetHierarchyAsync(planet);

        return planet;
    }

    public async Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var region = await GetPlanetByIdAsync(request.EntityId!.Value);
            return region != null ? [region] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var planetDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var planets = mapper.Map<HashSet<Planet>>(planetDocs);

            foreach (var planet in planets)
            {
                await SetPlanetHierarchyAsync(planet);
            }
        }

        return [];
    }

    public async Task<Planet> UpsertPlanetAsync(Planet planet)
    {
        var updatedPlanet = (Planet)await firestoreManager.UpsertAsync(planet, Collection);

        await SetPlanetHierarchyAsync(updatedPlanet);

        return updatedPlanet;
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await firestoreManager.DeleteAsync(planetId, Collection);
    }

    private async Task SetPlanetHierarchyAsync(Planet planet)
    {
        var starSystemDoc = await firestoreManager.GetByIdAsync(
            planet.StarSystemId,
            DatabaseConstants.StarSystemCollection);
        var starSystem = mapper.Map<StarSystem>(starSystemDoc);

        var regionData = await firestoreManager.GetByIdAsync(
            starSystem.RegionId,
            DatabaseConstants.RegionCollection);
        var region = mapper.Map<Region>(regionData);

        var galaxyData = await firestoreManager.GetByIdAsync(
            region.GalaxyId,
            DatabaseConstants.GalaxyCollection);

        region.Galaxy = mapper.Map<Galaxy>(galaxyData);
        starSystem.Region = region;
        planet.StarSystem = starSystem;
    }
}