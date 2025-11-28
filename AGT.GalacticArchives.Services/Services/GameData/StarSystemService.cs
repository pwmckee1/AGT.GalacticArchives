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
        if (!starSystem.RegionId.HasValue && starSystem.Region == null)
        {
            throw new ArgumentException("Star System must have either a new Region or an existing Region");
        }

        if (starSystem.Region != null)
        {
            if (!starSystem.Region.GalaxyId.HasValue)
            {
                throw new ArgumentException("Regions must have a Galaxy");
            }

            var galaxyData = await starSystemManager.GetByIdAsync(starSystem.Region.GalaxyId.GetValueOrDefault(), DatabaseConstants.GalaxyCollection);
            if (starSystem.Region.Galaxy != null && (galaxyData.Count == 0 || galaxyData.HasAnyChanges(starSystem.Region.Galaxy.ToDictionary())))
            {
                await starSystemManager.UpsertAsync(starSystem.Region.Galaxy, DatabaseConstants.GalaxyCollection);
            }
        }

        var regionData = await starSystemManager.GetByIdAsync(starSystem.RegionId.GetValueOrDefault(), DatabaseConstants.RegionCollection);
        if (starSystem.Region != null && (regionData.Count == 0 || regionData.HasAnyChanges(starSystem.Region.ToDictionary())))
        {
            await starSystemManager.UpsertAsync(starSystem.Region, DatabaseConstants.RegionCollection);
        }

        var starSystemData = await starSystemManager.GetByIdAsync(starSystem.StarSystemId, DatabaseConstants.StarSystemCollection);
        if (starSystemData.Count == 0 || starSystemData.HasAnyChanges(starSystem.ToDictionary()))
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