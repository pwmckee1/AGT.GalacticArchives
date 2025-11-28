using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

/// <summary>
/// Manages operations for galaxies, including retrieving, creating, updating, and deleting galaxy records
/// </summary>
/// <remarks>
/// This class integrates with Firestore for persistence and retrieval of galaxy data.
/// It also uses AutoMapper to handle data transformation.
/// </remarks>
public interface IGalaxyManager
{
    Task<HashSet<Galaxy>> GetGalaxiesAsync();

    Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy);

    Task DeleteGalaxyAsync(Guid galaxyId);
}