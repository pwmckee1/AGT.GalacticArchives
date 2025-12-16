using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameEntities;

public class FaunaManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : IFaunaManager
{
    private const string Collection = DatabaseConstants.FaunaCollection;

    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var faunaDoc = await firestoreManager.GetByIdAsync(faunaId, Collection);
        var fauna = mapper.Map<Fauna>(faunaDoc);

        if (fauna == null)
        {
            return null;
        }

        fauna.Planet = fauna.PlanetId.HasValue
            ? await galacticEntityManager.GetPlanetaryHierarchyAsync(fauna.PlanetId!.Value)
            : null;

        return fauna;
    }

    public async Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request)
    {
        if (request.FaunaId.HasValue)
        {
            var fauna = await GetFaunaByIdAsync(request.FaunaId!.Value);

            return fauna != null ? [fauna] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            const string planetIdKey = nameof(Fauna.PlanetId);
            string? name = request.Name;
            var planetId = request.PlanetId!.Value;

            var faunaRef = request.FaunaId.HasValue
                ? await firestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var faunae = mapper.Map<HashSet<Fauna>>(faunaRef);

            foreach (var fauna in faunae)
            {
                fauna.Planet = await galacticEntityManager.GetPlanetaryHierarchyAsync(fauna.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await firestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<Fauna>> UpsertFaunaAsync(HashSet<Fauna> request, CancellationToken ct)
    {
        return await firestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await firestoreManager.DeleteAsync(faunaId, Collection);
    }
}