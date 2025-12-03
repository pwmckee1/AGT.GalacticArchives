using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class StarshipManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : IStarshipManager
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

        var parentId = starship.PlanetId ?? starship.StarSystemId!.Value;
        await SetStarshipHierarchies(starship, parentId);

        return starship;
    }

    public async Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request)
    {
        if (request.StarSystemId.HasValue)
        {
            var starship = await GetStarshipByIdAsync(request.StarSystemId!.Value);

            return starship != null ? [starship] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            bool hasParentPlanet = request.PlanetId.HasValue;
            var parentId = request.PlanetId ?? request.StarSystemId!.Value;

            string? parentIdName = hasParentPlanet switch
            {
                true when !request.StarSystemId.HasValue => nameof(StarshipRequest.PlanetId),
                false when request.StarSystemId.HasValue => nameof(StarshipRequest.StarSystemId),
                _ => null,
            };

            var starshipDocs = hasParentPlanet
                ? await firestoreManager.GetByNameAsync(request.Name, parentIdName!, parentId, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var starships = mapper.Map<HashSet<Starship>>(starshipDocs);

            foreach (var starship in starships)
            {
                await SetStarshipHierarchies(starship, parentId);
            }
        }

        return [];
    }

    public async Task<Starship> UpsertStarshipAsync(Starship request)
    {
        var updatedStarship = (Starship)await firestoreManager.UpsertAsync(request, Collection);

        var parentId = request.PlanetId ?? request.StarSystemId!.Value;
        await SetStarshipHierarchies(updatedStarship, parentId);

        return updatedStarship;
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await firestoreManager.DeleteAsync(starshipId, Collection);
    }

    private async Task SetStarshipHierarchies(Starship starship, Guid parentId)
    {
        if (starship.PlanetId.HasValue)
        {
            starship.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(parentId);
        }
        else
        {
            starship.StarSystem = await entityHierarchyManager.GetStarSystemWithHierarchyAsync(parentId);
        }
    }
}