using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public class RegionManager(IFirestoreManager firestoreManager, IMapper mapper) : IRegionManager
{
    private const string Collection = DatabaseConstants.RegionCollection;

    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var galaxyDoc = await firestoreManager.GetByIdAsync(regionId, Collection);
        var region = galaxyDoc != null ? mapper.Map<Region>(galaxyDoc) : null;

        if (region == null)
        {
            return null;
        }

        await GetRegionHierarchyAsync(region);

        return region;
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
            var regionDocs = request.GalaxyId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(Region.GalaxyId), request.GalaxyId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var regions = mapper.Map<HashSet<Region>>(regionDocs);

            foreach (var region in regions)
            {
                await GetRegionHierarchyAsync(region);
            }
        }

        return [];
    }

    public async Task<Region> UpsertRegionAsync(Region request)
    {
        return (Region)await firestoreManager.UpsertAsync(request, Collection);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await firestoreManager.DeleteAsync(regionId, Collection);
    }

    private async Task GetRegionHierarchyAsync(Region region)
    {
        var galaxyData = await firestoreManager.GetByIdAsync(
            region.GalaxyId,
            DatabaseConstants.GalaxyCollection);

        region.Galaxy = mapper.Map<Galaxy>(galaxyData);
    }
}