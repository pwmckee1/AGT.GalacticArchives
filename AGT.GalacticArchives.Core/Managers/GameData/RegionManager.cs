using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class RegionManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<IGameData>(firestoreDb, mapper), IRegionManager
{
    /// <summary>
    /// Retrieves a region by its unique identifier, including associated galaxy data.
    /// </summary>
    /// <param name="regionId">The unique identifier of the region to retrieve.</param>
    /// <returns>The region matching the specified identifier, or null if no match is found.</returns>
    public async Task<Region?> GetRegionByIdAsync(Guid regionId)
    {
        var regiondata = await GetByIdAsync(regionId, DatabaseConstants.RegionCollection);

        if (regiondata.Count == 0)
        {
            return null;
        }

        var region = Mapper.Map<Region>(regiondata);

        var galaxyData = await GetByIdAsync(region.GalaxyId!.Value, DatabaseConstants.RegionCollection);
        region.Galaxy = Mapper.Map<Galaxy>(galaxyData);

        return region;
    }

    /// <summary>
    /// Inserts or updates the provided region, and the region's galaxy in the database.
    /// </summary>
    /// <param name="region">The region object to be inserted or updated in the database.</param>
    /// <returns>The upserted region with updated information.</returns>
    public async Task<Region> UpsertRegionAsync(Region region)
    {
        await UpsertAsync(region.Galaxy!, DatabaseConstants.GalaxyCollection);

        await UpsertAsync(region, DatabaseConstants.RegionCollection);

        return region;
    }

    /// <summary>
    /// Deletes the specified region from the database.
    /// </summary>
    /// <param name="regionId">The unique identifier of the region to be deleted.</param>
    /// <returns>A task that represents the asynchronous delete operation.</returns>
    public async Task DeleteRegionAsync(Guid regionId)
    {
        await DeleteAsync(regionId, DatabaseConstants.RegionCollection);
    }
}