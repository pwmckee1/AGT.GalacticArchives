using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public interface IGalaxyManager
{
    Task<HashSet<Galaxy>> GetGalaxiesAsync();

    Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request);

    Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId);

    Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy);

    Task DeleteGalaxyAsync(Guid galaxyId);
}