using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class RegionManager(IFirestoreManager firestoreManager, IMapper mapper) : GameEntityManager(firestoreManager), IRegionManager
{
    protected override string Collection => DatabaseConstants.RegionCollection;

    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var regionDoc = await FirestoreManager.GetByIdAsync(regionId, Collection);
        var region = regionDoc.Count > 0 ? mapper.Map<Region>(regionDoc) : null;

        return region ?? null;
    }

    public async Task<Region> UpsertRegionAsync(Region request)
    {
        return await FirestoreManager.UpsertAsync(request, Collection);
    }

    public async Task<HashSet<Region>> UpsertRegionAsync(HashSet<Region> request, CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await FirestoreManager.DeleteAsync(regionId, Collection);
    }
}