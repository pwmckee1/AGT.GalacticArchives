using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.Caching;

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
            $"{nameof(StarSystem)}:{request.StarSystemId}",
            async () => await target.GetStarSystemsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem)
    {
        var result = await target.UpsertStarSystemAsync(starSystem);
        await cacheManager.SetAsync(
            $"{nameof(StarSystem)}:{starSystem.StarSystemId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<StarSystem>> UpsertStarSystemAsync(HashSet<StarSystem> request)
    {
        var result = await target.UpsertStarSystemAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(StarSystem)}:{BusinessRuleConstants.AllCacheKey}",
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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(StarSystem)}:{BusinessRuleConstants.AllCacheKey}");
    }
}