using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedPlanetManager(ICacheManager cacheManager, IPlanetManager target)
    : IPlanetManager, ICachedGameDataManager
{
    public async Task<Planet?> GetPlanetByIdAsync(Guid planetId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Planet)}:{planetId}",
            async () => await target.GetPlanetByIdAsync(planetId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as PlanetSearchRequest);
        string cacheKey = $"{nameof(Planet)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Planet> UpsertPlanetAsync(Planet request)
    {
        var result = await target.UpsertPlanetAsync(request);
        await cacheManager.SetAsync($"{nameof(Planet)}:{request.PlanetId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<Planet>> UpsertPlanetAsync(HashSet<Planet> request, CancellationToken ct)
    {
        var result = await target.UpsertPlanetAsync(request, ct);
        var planetIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var planetId in planetIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Planet)}:{planetId}");
        }

        return result;
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await target.DeletePlanetAsync(planetId);
        await ClearCacheAsync(planetId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Planet)}:{BusinessRuleConstants.AllCacheKey}");
    }
}