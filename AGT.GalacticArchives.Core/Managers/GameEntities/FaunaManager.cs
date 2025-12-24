using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class FaunaManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : GameEntityManager(firestoreManager), IFaunaManager
{
    protected override string Collection => DatabaseConstants.FaunaCollection;

    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var faunaDoc = await FirestoreManager.GetByIdAsync(faunaId, Collection);
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

    public async Task<HashSet<Fauna>> GetFaunaAsync(FaunaSearchRequest request)
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
                ? await FirestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await FirestoreManager.GetByNameAsync(request.Name, Collection);

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
        await FirestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<Fauna>> UpsertFaunaAsync(HashSet<Fauna> request, CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await FirestoreManager.DeleteAsync(faunaId, Collection);
    }
}