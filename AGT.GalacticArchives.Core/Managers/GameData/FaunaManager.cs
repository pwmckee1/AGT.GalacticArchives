using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class FaunaManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<Fauna>(firestoreDb, mapper), IFaunaManager
{
    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var snapshot = await GetByIdAsync(faunaId, DatabaseConstants.FaunaCollection);

        var fauna = Mapper.Map<Fauna>(snapshot);

        fauna.Planet = await GetPlanetWithHierarchyAsync(fauna.PlanetId);

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
            var snapshots = request.ParentId.HasValue
                ? GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.FaunaCollection)
                : GetByNameAsync(request.Name!, DatabaseConstants.FaunaCollection);

            var faunaSet = Mapper.Map<HashSet<Fauna>>(snapshots);
            foreach (var fauna in faunaSet) fauna.Planet = await GetPlanetWithHierarchyAsync(fauna.PlanetId);

            return faunaSet;
        }

        return [];
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna fauna)
    {
        return await UpsertAsync(fauna, DatabaseConstants.FaunaCollection);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await DeleteAsync(faunaId, DatabaseConstants.FaunaCollection);
    }
}