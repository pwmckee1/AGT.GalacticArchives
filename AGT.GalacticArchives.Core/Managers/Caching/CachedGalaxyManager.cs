using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedGalaxyManager(ICacheManager cacheManager, IGalaxyManager target) : IGalaxyManager
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxiesAsync)}",
            async () => await target.GetGalaxiesAsync(),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{nameof(GetGalaxyByIdAsync)}",
            async () => await target.GetGalaxyByIdAsync(galaxyId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        return await target.UpsertGalaxyAsync(galaxy);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await target.DeleteGalaxyAsync(galaxyId);
    }
}