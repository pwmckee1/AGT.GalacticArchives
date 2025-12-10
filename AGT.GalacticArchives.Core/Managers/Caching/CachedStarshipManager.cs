using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedStarshipManager(ICacheManager cacheManager, IStarshipManager target)
    : IStarshipManager, ICachedGameDataManager
{
    public async Task<Starship?> GetStarshipByIdAsync(Guid starshipId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{starshipId}",
            async () => await target.GetStarshipByIdAsync(starshipId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Starship)}:{request.StarshipId}",
            async () => await target.GetStarshipsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Starship> UpsertStarshipAsync(Starship request)
    {
        var result = await target.UpsertStarshipAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(Starship)}:{request.StarshipId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task DeleteStarshipAsync(Guid starshipId)
    {
        await target.DeleteStarshipAsync(starshipId);
        await ClearCacheAsync(starshipId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Starship)}:{entityId}");
    }
}