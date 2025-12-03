using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class FaunaManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : IFaunaManager
{
    private const string Collection = DatabaseConstants.FaunaCollection;

    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var faunaDoc = await firestoreManager.GetByIdAsync(faunaId, Collection);
        var fauna = faunaDoc != null ? mapper.Map<Fauna>(faunaDoc) : null;

        if (fauna == null)
        {
            return null;
        }

        fauna.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);

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
            var faunaDocs = request.FaunaId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(Fauna.PlanetId), request.PlanetId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var faunae = mapper.Map<HashSet<Fauna>>(faunaDocs);

            foreach (var fauna in faunae)
            {
                fauna.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna fauna)
    {
        var updatedFauna = (Fauna)await firestoreManager.UpsertAsync(fauna, Collection);
        updatedFauna.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);
        return updatedFauna;
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await firestoreManager.DeleteAsync(faunaId, Collection);
    }
}