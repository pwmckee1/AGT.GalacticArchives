using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

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

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as StarshipSearchRequest);
        string cacheKey = $"{nameof(Starship)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
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

    public async Task<HashSet<Starship>> UpsertStarshipAsync(HashSet<Starship> request, CancellationToken ct)
    {
        var result = await target.UpsertStarshipAsync(request, ct);
        var starshipIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var starshipId in starshipIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Starship)}:{starshipId}");
        }

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
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Starship)}:{BusinessRuleConstants.AllCacheKey}");
    }
}