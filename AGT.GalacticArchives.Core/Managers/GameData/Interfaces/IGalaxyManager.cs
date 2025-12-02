using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IGalaxyManager : IGameDataManager<Galaxy>
{
    Task<HashSet<Galaxy>> GetGalaxiesAsync();

    Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request);

    Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy);

    Task DeleteGalaxyAsync(Guid galaxyId);
}