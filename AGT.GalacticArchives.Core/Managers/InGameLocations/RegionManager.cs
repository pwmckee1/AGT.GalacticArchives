using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameLocations;

public class RegionManager(IFirestoreManager firestoreManager, IMapper mapper) : IRegionManager
{
    private const string Collection = DatabaseConstants.RegionCollection;

    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var regionDoc = await firestoreManager.GetByIdAsync(regionId, Collection);
        var region = regionDoc.Count > 0 ? mapper.Map<Region>(regionDoc) : null;

        return region ?? null;
    }

    public async Task<PagedDatabaseResponse> GetRegionsAsync(RegionSearchRequest request)
    {
        var requestQuery = request.ToDictionary();
        if (requestQuery.Count > 0)
        {
            var regionDocs = await firestoreManager.GetAsync(
                Collection,
                requestQuery,
                request.PageNumber,
                request.PageSize,
                request.OrderBy);

            return regionDocs;
        }

        return new PagedDatabaseResponse();
    }

    public async Task<Region> UpsertRegionAsync(Region request)
    {
        return await firestoreManager.UpsertAsync(request, Collection);
    }

    public async Task<HashSet<Region>> UpsertRegionAsync(HashSet<Region> request, CancellationToken ct)
    {
        return await firestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await firestoreManager.DeleteAsync(regionId, Collection);
    }
}