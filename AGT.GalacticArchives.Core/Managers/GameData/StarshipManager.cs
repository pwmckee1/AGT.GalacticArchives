using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class StarshipManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<Starship>(firestoreDb, mapper), IStarshipManager
{
    public async Task<Starship?> GetStarshipByIdAsync(Guid starshipId)
    {
        var snapshot = await GetByIdAsync(starshipId, DatabaseConstants.StarshipCollection);

        var starship = Mapper.Map<Starship>(snapshot);

        starship.Planet = await GetPlanetWithHierarchyAsync(starship.PlanetId!.Value);

        return starship;
    }

    public async Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request)
    {
        if (request.StarshipId.HasValue)
        {
            var starship = await GetStarshipByIdAsync(request.StarshipId!.Value);
            return starship != null ? [starship] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? await GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.StarshipCollection)
                : await GetByNameAsync(request.Name!, DatabaseConstants.StarshipCollection);

            var starshipSet = Mapper.Map<HashSet<Starship>>(snapshots);
            foreach (var starship in starshipSet)
            {
                if (starship.PlanetId.HasValue)
                {
                    starship.Planet = await GetPlanetWithHierarchyAsync(starship.PlanetId!.Value);
                }
                else
                {
                    starship.StarSystem = await GetStarSystemWithHierarchyAsync(starship.StarSystemId);
                }
            }

            return starshipSet;
        }

        return [];
    }

    public async Task<Starship> UpsertStarshipAsync(Starship starship)
    {
        var starshipData = await UpsertAsync(starship, DatabaseConstants.StarshipCollection);

        return Mapper.Map<Starship>(starshipData);
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await DeleteAsync(starshipId, DatabaseConstants.StarshipCollection);
    }
}