using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class StarshipManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IPlanetEntityManager planetEntityManager) : IStarshipManager
{
    private const string Collection = DatabaseConstants.StarshipCollection;

    public async Task<Starship?> GetStarshipByIdAsync(Guid starshipId)
    {
        var starshipDoc = await firestoreManager.GetByIdAsync(starshipId, Collection);
        var starship = starshipDoc != null ? mapper.Map<Starship>(starshipDoc) : null;

        if (starship == null)
        {
            return null;
        }

        await SetStarshipHierarchies(starship);

        return starship;
    }

    public async Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var starship = await GetStarshipByIdAsync(request.EntityId!.Value);

            return starship != null ? [starship] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var starshipDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var starships = mapper.Map<HashSet<Starship>>(starshipDocs);

            foreach (var starship in starships)
            {
                await SetStarshipHierarchies(starship);
            }
        }

        return [];
    }

    public async Task<Starship> UpsertStarshipAsync(Starship starship)
    {
        var updatedStarship = (Starship)await firestoreManager.UpsertAsync(starship, Collection);

        await SetStarshipHierarchies(updatedStarship);

        return updatedStarship;
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await firestoreManager.DeleteAsync(starshipId, Collection);
    }

    private async Task SetStarshipHierarchies(Starship starship)
    {
        if (starship.PlanetId.HasValue)
        {
            starship.Planet = await planetEntityManager.GetPlanetWithHierarchyAsync(starship.ParentId);
        }
        else
        {
            starship.StarSystem = await planetEntityManager.GetStarSystemWithHierarchyAsync(starship.ParentId);
        }
    }
}