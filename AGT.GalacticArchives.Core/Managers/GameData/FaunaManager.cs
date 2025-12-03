using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class FaunaManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IInnerSystemEntityManager innerSystemEntityManager) : IFaunaManager
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

        fauna.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);

        return fauna;
    }

    public async Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var fauna = await GetFaunaByIdAsync(request.EntityId!.Value);

            return fauna != null ? [fauna] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var faunaDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var faunae = mapper.Map<HashSet<Fauna>>(faunaDocs);

            foreach (var fauna in faunae)
            {
                fauna.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna fauna)
    {
        var updatedFauna = (Fauna)await firestoreManager.UpsertAsync(fauna, Collection);
        updatedFauna.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(fauna.PlanetId!.Value);
        return updatedFauna;
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await firestoreManager.DeleteAsync(faunaId, Collection);
    }
}