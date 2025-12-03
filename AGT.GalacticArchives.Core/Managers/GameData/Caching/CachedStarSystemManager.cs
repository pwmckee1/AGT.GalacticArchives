using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedStarSystemManager(ICacheManager cacheManager, IStarSystemManager target)
    : IStarSystemManager, ICachedGameDataManager
{
    public async Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{starSystemId}",
            async () => await target.GetStarSystemByIdAsync(starSystemId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<StarSystem>> GetStarSystemsAsync(StarSystemRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(StarSystem)}:{request.EntityId}",
            async () => await target.GetStarSystemsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var result = await target.UpsertStarSystemAsync(starSystem);
        await cacheManager.SetAsync(
            $"{nameof(StarSystem)}:{starSystem.EntityId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await target.DeleteStarSystemAsync(starSystemId);
        await ClearCacheAsync(starSystemId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{entityId}");
    }
}