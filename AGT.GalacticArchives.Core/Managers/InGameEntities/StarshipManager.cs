using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameEntities;

public class StarshipManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : IStarshipManager
{
    private const string Collection = DatabaseConstants.StarshipCollection;

    public async Task<Starship?> GetStarshipByIdAsync(Guid starshipId)
    {
        var starshipDoc = await firestoreManager.GetByIdAsync(starshipId, Collection);
        var starship = mapper.Map<Starship>(starshipDoc);

        if (starship == null)
        {
            return null;
        }

        var parentId = starship.PlanetId ?? starship.StarSystemId!.Value;
        await SetStarshipHierarchy(starship, parentId);

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
                await SetStarshipHierarchy(starship, parentId);
            }
        }

        return [];
    }

    public async Task<Starship> UpsertStarshipAsync(Starship request)
    {
        await UpdateStarshipHierarchy(request);
        await firestoreManager.UpsertAsync(request, Collection);
        return request!;
    }

    public async Task<HashSet<Starship>> UpsertStarshipAsync(HashSet<Starship> request, CancellationToken ct)
    {
        return await firestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await firestoreManager.DeleteAsync(starshipId, Collection);
    }

    private async Task SetStarshipHierarchy(Starship starship, Guid parentId)
    {
        if (starship.PlanetId.HasValue)
        {
            starship.Planet = await galacticEntityManager.GetPlanetaryHierarchyAsync(parentId);
        }
        else
        {
            starship.StarSystem = await galacticEntityManager.GetStarSystemHierarchyAsync(parentId);
        }
    }

    private async Task UpdateStarshipHierarchy(Starship starship)
    {
        if (starship.Planet == null && starship.StarSystem == null)
        {
            return;
        }

        StarSystem? starSystem = null;
        if (starship.Planet != null)
        {
            await galacticEntityManager.UpsertPlanetAsync(starship.Planet);
            starSystem = starship.Planet!.StarSystem;
        }
        else if (starship.StarSystem != null)
        {
            starSystem = starship.StarSystem;
        }

        await galacticEntityManager.UpsertStarSystemAsync(starSystem);
        await galacticEntityManager.UpsertRegionAsync(starship.Planet!.StarSystem!.Region);
    }
}