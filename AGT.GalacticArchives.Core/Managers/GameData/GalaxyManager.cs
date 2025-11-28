using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

/// <summary>
/// Manages operations for galaxies, including retrieving, creating, updating, and deleting galaxy records
/// </summary>
/// <remarks>
/// This class integrates with Firestore for persistence and retrieval of galaxy data.
/// It also uses AutoMapper to handle data transformation.
/// </remarks>
public class GalaxyManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<IGameData>(firestoreDb, mapper), IGalaxyManager
{
    /// <summary>
    /// Retrieves a set of all galaxies stored in the database.
    /// </summary>
    /// <returns>
    /// A collection of galaxies.
    /// </returns>
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var data = await GetAllAsync(DatabaseConstants.GalaxyCollection);
        return Mapper.Map<HashSet<Galaxy>>(data);
    }

    /// <summary>
    /// Retrieves a galaxy by its unique identifier.
    /// </summary>
    /// <param name="galaxyId">
    /// The unique identifier of the galaxy to retrieve.
    /// </param>
    /// <returns>
    /// The galaxy corresponding to the specified identifier, or null if no galaxy is found.
    /// </returns>
    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var data = await GetByIdAsync(galaxyId, DatabaseConstants.GalaxyCollection);

        return data.Count == 0 ? null : Mapper.Map<Galaxy>(data);
    }

    /// <summary>
    /// Creates a new galaxy or updates an existing one in the database.
    /// </summary>
    /// <param name="galaxy">The galaxy object to be created or updated.</param>
    /// <returns>
    /// The created or updated galaxy object.
    /// </returns>
    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        var data = await UpsertAsync(galaxy, DatabaseConstants.GalaxyCollection);

        return Mapper.Map<Galaxy>(data);
    }

    /// <summary>
    /// Deletes a galaxy record from the database based on the provided identifier.
    /// </summary>
    /// <param name="galaxyId">
    /// The unique identifier of the galaxy to be deleted.
    /// </param>
    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await DeleteAsync(galaxyId, DatabaseConstants.GalaxyCollection);
    }
}