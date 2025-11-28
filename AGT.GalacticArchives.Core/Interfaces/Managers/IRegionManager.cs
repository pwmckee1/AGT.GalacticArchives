using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

/// <summary>
/// Manages operations related to galactic regions, including retrieval, insertion, updating, and deletion.
/// </summary>
/// <remarks>
/// This class integrates with Firestore for persistence and retrieval of region data.
/// It also uses AutoMapper to handle data transformation.
/// </remarks>
public interface IRegionManager
{
    /// <summary>
    /// Retrieves a region by its unique identifier, including associated galaxy data.
    /// </summary>
    /// <param name="regionId">The unique identifier of the region to retrieve.</param>
    /// <returns>The region matching the specified identifier, or null if no match is found.</returns>
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    /// <summary>
    /// Inserts or updates the provided region in the database.
    /// </summary>
    /// <param name="region">The region object to be inserted or updated in the database.</param>
    /// <returns>The upserted region with updated information.</returns>
    Task<Region> UpsertRegionAsync(Region region);

    /// <summary>
    /// Deletes the specified region from the database.
    /// </summary>
    /// <param name="regionId">The unique identifier of the region to be deleted.</param>
    /// <returns>A task that represents the asynchronous delete operation.</returns>
    Task DeleteRegionAsync(Guid regionId);
}