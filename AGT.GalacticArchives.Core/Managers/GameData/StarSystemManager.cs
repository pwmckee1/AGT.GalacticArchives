using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class StarSystemManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<StarSystem>(firestoreDb, mapper), IStarSystemManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        return await GetStarSystemWithHierarchyAsync(starSystemId);
    }

    public async Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request)
    {
        if (request.StarSystemId.HasValue)
        {
            var result = await GetStarSystemByIdAsync(request.StarSystemId!.Value);
            return result != null ? [result] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.StarSystemCollection)
                : GetByNameAsync(request.Name!, DatabaseConstants.StarSystemCollection);

            var starSystems = Mapper.Map<HashSet<StarSystem>>(snapshots);
            foreach (var starSystem in starSystems)
                starSystem.Region = await GetRegionWithHierarchyAsync(starSystem.RegionId);

            return starSystems;
        }

        return [];
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        await UpsertAsync(starSystem, DatabaseConstants.StarSystemCollection);

        return starSystem;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await DeleteAsync(starSystemId, DatabaseConstants.StarSystemCollection);
    }
}