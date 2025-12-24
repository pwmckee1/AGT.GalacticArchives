using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class PlanetManager(IFirestoreManager firestoreManager, IMapper mapper) : GameEntityManager(firestoreManager), IPlanetManager
{
    protected override string Collection => DatabaseConstants.PlanetCollection;

    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        var planetDoc = await FirestoreManager.GetByIdAsync(planetId, Collection);
        var planet = planetDoc.Count > 0 ? mapper.Map<Planet>(planetDoc) : null;

        if (planet == null)
        {
            return null;
        }

        await SetPlanetHierarchyAsync(planet);

        return planet;
    }

    public async Task<HashSet<Planet>> GetPlanetsAsync(PlanetSearchRequest request)
    {
        if (request.PlanetId.HasValue)
        {
            var region = await GetPlanetByIdAsync(request.PlanetId!.Value);
            return region != null ? [region] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var planetDocs = request.StarSystemId.HasValue
                ? await FirestoreManager.GetByNameAsync(
                    request.Name,
                    nameof(Planet.StarSystemId),
                    request.StarSystemId!.Value,
                    Collection)
                : await FirestoreManager.GetByNameAsync(request.Name, Collection);

            var planets = mapper.Map<HashSet<Planet>>(planetDocs);

            foreach (var planet in planets)
            {
                await SetPlanetHierarchyAsync(planet);
            }
        }

        return [];
    }

    public async Task<Planet> UpsertPlanetAsync(Planet request)
    {
        var updatedPlanet = await FirestoreManager.UpsertAsync(request, Collection);

        await SetPlanetHierarchyAsync(updatedPlanet);

        return updatedPlanet;
    }

    public async Task<HashSet<Planet>> UpsertPlanetAsync(HashSet<Planet> request, CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await FirestoreManager.DeleteAsync(planetId, Collection);
    }

    private async Task SetPlanetHierarchyAsync(Planet planet)
    {
        if (planet.StarSystemId.HasValue)
        {
            var starSystemDoc = await FirestoreManager.GetByIdAsync(
                planet.StarSystemId!.Value,
                DatabaseConstants.StarSystemCollection);
            var starSystem = mapper.Map<StarSystem>(starSystemDoc);

            if (starSystem != null)
            {
                planet.StarSystem = starSystem;
                if (starSystem.RegionId.HasValue)
                {
                    var regionData = await FirestoreManager.GetByIdAsync(
                        starSystem.RegionId!.Value,
                        DatabaseConstants.RegionCollection);
                    planet.StarSystem.Region = mapper.Map<Region>(regionData);
                }
            }
        }
    }
}