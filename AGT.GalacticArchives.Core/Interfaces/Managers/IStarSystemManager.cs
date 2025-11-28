using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

/// <summary>
/// Manages operations related to star systems, including retrieval, insertion, updating, and deletion.
/// </summary>
/// <remarks>
/// This class integrates with Firestore for persistence and retrieval of star system data.
/// It also uses AutoMapper to handle data transformation.
/// </remarks>
public interface IStarSystemManager
{
    /// <summary>
    /// Retrieves a star system by its unique identifier, including associated region and galaxy data.
    /// </summary>
    /// <param name="starSystemId">The unique identifier of the star system to retrieve.</param>
    /// <returns>The star system matching the specified identifier, or null if no match is found.</returns>
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    /// <summary>
    /// Inserts or updates the provided star system in the database.
    /// </summary>
    /// <param name="starSystem">The star system object to be inserted or updated in the database.</param>
    /// <returns>The upserted star system with updated information.</returns>
    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    /// <summary>
    /// Deletes the specified star system from the database.
    /// </summary>
    /// <param name="starSystemId">The unique identifier of the star system to be deleted.</param>
    /// <returns>A task that represents the asynchronous delete operation.</returns>
    Task DeleteStarSystemAsync(Guid starSystemId);
}