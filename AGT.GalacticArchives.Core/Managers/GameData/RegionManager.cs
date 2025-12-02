using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class RegionManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<Region>(firestoreDb, mapper), IRegionManager
{
    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        return await GetRegionWithHierarchyAsync(regionId);
    }

    public async Task<HashSet<Region>> GetRegionsAsync(RegionRequest request)
    {
        if (request.RegionId.HasValue)
        {
            var region = await GetRegionByIdAsync(request.RegionId!.Value);
            return region != null ? [region] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.RegionCollection)
                : GetByNameAsync(request.Name!, DatabaseConstants.RegionCollection);

            var regionSet = Mapper.Map<HashSet<Region>>(snapshots);
            foreach (var region in regionSet)
            {
                var galaxyData = await GetByIdAsync(region.GalaxyId, DatabaseConstants.GalaxyCollection);

                region.Galaxy = Mapper.Map<Galaxy>(galaxyData);
            }

            return regionSet;
        }

        return [];
    }

    public async Task<Region> UpsertRegionAsync(Region region)
    {
        return await UpsertAsync(region, DatabaseConstants.RegionCollection);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await DeleteAsync(regionId, DatabaseConstants.RegionCollection);
    }
}