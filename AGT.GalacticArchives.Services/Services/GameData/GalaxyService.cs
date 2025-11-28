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

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        return await galaxyManager.UpsertGalaxyAsync(galaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await galaxyManager.DeleteGalaxyAsync(galaxyId);
    }
}