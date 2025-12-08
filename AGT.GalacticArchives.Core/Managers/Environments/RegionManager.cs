using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public class RegionManager(IFirestoreManager firestoreManager, IMapper mapper) : IRegionManager
{
    private const string Collection = DatabaseConstants.RegionCollection;

    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var regionDoc = await firestoreManager.GetByIdAsync(regionId, Collection);
        var region = regionDoc.Count > 0 ? mapper.Map<Region>(regionDoc) : null;

        return region ?? null;
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
            var regionDocs = await firestoreManager.GetByNameAsync(request.Name, Collection);

            return mapper.Map<HashSet<Region>>(regionDocs);
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
}