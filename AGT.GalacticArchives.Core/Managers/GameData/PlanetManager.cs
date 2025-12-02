using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PlanetManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<Planet>(firestoreDb, mapper), IPlanetManager
{
    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        return await GetPlanetWithHierarchyAsync(planetId);
    }

    public async Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request)
    {
        if (request.PlanetId.HasValue)
        {
            var planet = await GetPlanetByIdAsync(request.PlanetId!.Value);
            return planet != null ? [planet] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? await GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.PlanetCollection)
                : await GetByNameAsync(request.Name!, DatabaseConstants.PlanetCollection);

            var planetSet = Mapper.Map<HashSet<Planet>>(snapshots);
            foreach (var planet in planetSet)
                planet.StarSystem = await GetStarSystemWithHierarchyAsync(planet.StarSystemId);

            return planetSet;
        }

        return [];
    }

    public async Task<Planet> UpsertPlanetAsync(Planet planet)
    {
        return await UpsertAsync(planet, DatabaseConstants.PlanetCollection);
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await DeleteAsync(planetId, DatabaseConstants.PlanetCollection);
    }
}