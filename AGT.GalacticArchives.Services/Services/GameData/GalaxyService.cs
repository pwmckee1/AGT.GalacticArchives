using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class GalaxyService(IGalaxyManager galaxyManager) : IGalaxyService
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        return await galaxyManager.GetGalaxiesAsync();
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        return await galaxyManager.GetGalaxyByIdAsync(galaxyId);
    }

    /// <summary>
    /// Inserts or updates a galaxy in the data store only If the associated galaxy
    /// data has changed. This is done in the service layer to use the cache manager for the
    /// duplicate check to reduce firestore db calls when no necessary
    /// </summary>
    /// <param name="galaxy">
    /// The galaxy entity to upsert, including its associated galaxy and region data.
    /// </param>
    /// <returns>
    /// The upserted <see cref="Galaxy"/> object containing the latest persisted data.
    /// </returns>
    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        var galaxyData = await galaxyManager.GetByIdAsync(galaxy.GalaxyId, DatabaseConstants.GalaxyCollection);
        if (galaxyData.HasAnyChanges(galaxy.ToDictionary()))
        {
            galaxy = await galaxyManager.UpsertGalaxyAsync(galaxy);
        }

        return galaxy;
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyManager.DeleteGalaxyAsync(galaxyId);
    }
}