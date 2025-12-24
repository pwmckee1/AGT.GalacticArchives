using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;

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

    public async Task<HashSet<GameRelease>> GetGameReleasesAsync(GameReleaseRequest request)
    {
        string cacheKey = request.ReleaseId.HasValue ? $"{nameof(GameRelease)}:{request.ReleaseId}" : $"{nameof(GameRelease)}s";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetGameReleasesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<GameRelease> UpsertGameReleaseAsync(GameRelease request)
    {
        var result = await target.UpsertGameReleaseAsync(request);
        await cacheManager.SetAsync($"{nameof(GameRelease)}:{request.EntityId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<GameRelease>> UpsertGameReleaseAsync(HashSet<GameRelease> request, CancellationToken ct)
    {
        var result = await target.UpsertGameReleaseAsync(request, ct);
        var gameReleaseIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var gameReleaseId in gameReleaseIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(GameRelease)}:{gameReleaseId}");
        }

        return result;
    }

    public async Task DeleteGameReleaseAsync(Guid gameReleaseId)
    {
        await target.DeleteGameReleaseAsync(gameReleaseId);
        await ClearCacheAsync(gameReleaseId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(GameRelease)}:{BusinessRuleConstants.AllCacheKey}");
    }
}