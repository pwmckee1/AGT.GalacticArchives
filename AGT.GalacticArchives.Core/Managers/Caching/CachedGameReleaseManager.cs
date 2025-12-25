using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedGameReleaseManager(ICacheManager cacheManager, IGameReleaseManager target)
    : IGameReleaseManager, ICachedGameDataManager
{
    public async Task<GameRelease?> GetGameReleaseByIdAsync(Guid gameReleaseId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(GameRelease)}:{gameReleaseId}",
            async () => await target.GetGameReleaseByIdAsync(gameReleaseId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetGameReleasesAsync(GameReleaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request);
        string cacheKey = $"{nameof(GameRelease)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetGameReleasesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<GameRelease> UpsertGameReleaseAsync(GameRelease request)
    {
        var result = await target.UpsertGameReleaseAsync(request);
        await ClearCacheAsync(request.EntityId);
        await cacheManager.SetAsync($"{nameof(GameRelease)}:{request.EntityId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<GameRelease>> UpsertGameReleaseAsync(HashSet<GameRelease> request, CancellationToken ct)
    {
        var result = await target.UpsertGameReleaseAsync(request, ct);
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}s");

        return result;
    }

    public async Task DeleteGameReleaseAsync(Guid gameReleaseId)
    {
        await target.DeleteGameReleaseAsync(gameReleaseId);
        await ClearCacheAsync(gameReleaseId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}s");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}:{BusinessRuleConstants.AllCacheKey}");
    }
}