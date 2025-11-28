using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class StarSystemService(IStarSystemManager starSystemManager) : IStarSystemService
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        return await starSystemManager.GetStarSystemByIdAsync(starSystemId);
    }

    /// <summary>
    /// Inserts or updates a star system in the data store. If the associated galaxy or region
    /// data has changed, these are also updated. This is done in the service layer to use the cache manager for the
    /// duplicate check to reduce firestore db calls when no necessary
    /// </summary>
    /// <param name="starSystem">
    /// The star system entity to upsert, including its associated galaxy and region data.
    /// </param>
    /// <returns>
    /// The upserted <see cref="StarSystem"/> object containing the latest persisted data.
    /// </returns>
    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var galaxyData = await starSystemManager.GetByIdAsync(starSystem.Region.GalaxyId, DatabaseConstants.GalaxyCollection);
        if (galaxyData.HasAnyChanges(starSystem.Region.Galaxy.ToDictionary()))
        {
            await starSystemManager.UpsertAsync(starSystem.Region.Galaxy, DatabaseConstants.GalaxyCollection);
        }

        var regionData = await starSystemManager.GetByIdAsync(starSystem.RegionId, DatabaseConstants.RegionCollection);
        if (regionData.HasAnyChanges(starSystem.Region.ToDictionary()))
        {
            await starSystemManager.UpsertAsync(starSystem.Region, DatabaseConstants.RegionCollection);
        }

        var starSystemData = await starSystemManager.GetByIdAsync(starSystem.StarSystemId, DatabaseConstants.StarSystemCollection);
        if (starSystemData.HasAnyChanges(starSystem.ToDictionary()))
        {
            starSystem = await starSystemManager.UpsertStarSystemAsync(starSystem);
        }

        return starSystem;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await starSystemManager.DeleteStarSystemAsync(starSystemId);
    }
}