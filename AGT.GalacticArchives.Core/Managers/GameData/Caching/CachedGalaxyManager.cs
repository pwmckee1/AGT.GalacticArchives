using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedGalaxyManager(ICacheManager cacheManager, IGalaxyManager target)
    : IGalaxyManager, ICachedGameDataManager
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(GetGalaxiesAsync)}",
            async () => await target.GetGalaxiesAsync(),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{request.EntityId}",
            async () => await target.GetGalaxiesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Galaxy)}:{galaxyId}",
            async () => await target.GetGalaxyByIdAsync(galaxyId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        var result = await target.UpsertGalaxyAsync(galaxy);
        await cacheManager.SetAsync($"{nameof(Galaxy)}:{galaxy.EntityId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await target.DeleteGalaxyAsync(galaxyId);
        await ClearCacheAsync(galaxyId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GetGalaxiesAsync)}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Galaxy)}:{entityId}");
    }
}