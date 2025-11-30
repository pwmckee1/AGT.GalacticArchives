using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

/// <summary>
/// Manages operations related to star systems, including retrieval, insertion, updating, and deletion.
/// </summary>
/// <remarks>
/// This class integrates with Firestore for persistence and retrieval of star system data.
/// It also uses AutoMapper to handle data transformation.
/// </remarks>
public class StarSystemManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<IGameData>(firestoreDb, mapper), IStarSystemManager
{
    /// <summary>
    /// Retrieves a star system by its unique identifier, including associated region and galaxy data.
    /// </summary>
    /// <param name="starSystemId">The unique identifier of the star system to retrieve.</param>
    /// <returns>The star system matching the specified identifier, or null if no match is found.</returns>
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystemdata = await GetByIdAsync(starSystemId, DatabaseConstants.StarSystemCollection);

        if (starSystemdata.Count == 0)
        {
            return null;
        }

        var starSystem = Mapper.Map<StarSystem>(starSystemdata);

        var regionData = await GetByIdAsync(starSystem.RegionId.GetValueOrDefault(), DatabaseConstants.RegionCollection);
        var region = Mapper.Map<Region>(regionData);

        var galaxyData = await GetByIdAsync(region.GalaxyId!.Value, DatabaseConstants.RegionCollection);
        region.Galaxy = Mapper.Map<Galaxy>(galaxyData);

        starSystem.Region = region;

        return starSystem;
    }

    /// <summary>
    /// Inserts or updates the provided star system, it's region, and it's galaxy in the database.
    /// </summary>
    /// <param name="starSystem">The star system object to be inserted or updated in the database.</param>
    /// <returns>The upserted star system with updated information.</returns>
    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        await UpsertAsync(starSystem, DatabaseConstants.StarSystemCollection);

        return starSystem;
    }

    /// <summary>
    /// Deletes the specified star system from the database.
    /// </summary>
    /// <param name="starSystemId">The unique identifier of the star system to be deleted.</param>
    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await DeleteAsync(starSystemId, DatabaseConstants.StarSystemCollection);
    }
}