using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGalaxyManager
{
    Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId);

    Task CreateOrUpdateGalaxyAsync(Galaxy galaxy);

    Task DeleteGalaxyAsync(Guid galaxyId);
}