using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class RegionService(IRegionManager regionManager) : IRegionService
{
    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        return await regionManager.GetRegionByIdAsync(regionId);
    }

    /// <summary>
    /// Inserts or updates a region in the data store. If the associated galaxy
    /// data has changed, it is also updated. This is done in the service layer to use the cache manager for the
    /// duplicate check to reduce firestore db calls when no necessary
    /// </summary>
    /// <param name="region">
    /// The region entity to upsert, including its associated galaxy and region data.
    /// </param>
    /// <returns>
    /// The upserted <see cref="Region"/> object containing the latest persisted data.
    /// </returns>
    public async Task<Region> UpsertRegionAsync(Region region)
    {
        var galaxyData = await regionManager.GetByIdAsync(region.GalaxyId, DatabaseConstants.GalaxyCollection);
        if (galaxyData.HasAnyChanges(region.Galaxy.ToDictionary()))
        {
            await regionManager.UpsertAsync(region.Galaxy, DatabaseConstants.GalaxyCollection);
        }

        var regionData = await regionManager.GetByIdAsync(region.RegionId, DatabaseConstants.RegionCollection);
        if (regionData.HasAnyChanges(region.ToDictionary()))
        {
           region = await regionManager.UpsertRegionAsync(region);
        }

        return region;
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await regionManager.DeleteRegionAsync(regionId);
    }
}