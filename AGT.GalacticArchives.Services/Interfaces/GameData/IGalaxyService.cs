using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Services.Interfaces.GameData;

public interface IGalaxyService
{
    Task<HashSet<Galaxy>> GetGalaxiesAsync();

    Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy);

    Task DeleteGalaxyAsync(Guid galaxyId);
}