using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedPlayerBaseManager(ICacheManager cacheManager, IPlayerBaseManager target)
    : IPlayerBaseManager, ICachedGameDataManager
{
    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{playerBaseId}",
            async () => await target.GetPlayerBaseByIdAsync(playerBaseId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PlayerBase)}:{request.PlayerBaseId}",
            async () => await target.GetPlayerBasesAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request)
    {
        var result = await target.UpsertPlayerBaseAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(PlayerBase)}:{request.PlayerBaseId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<PlayerBase>> UpsertPlayerBaseAsync(HashSet<PlayerBase> request, CancellationToken ct)
    {
        var result = await target.UpsertPlayerBaseAsync(request, ct);
        var playerBaseIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var playerBaseId in playerBaseIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(PlayerBase)}:{playerBaseId}");
        }

        return result;
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await target.DeletePlayerBaseAsync(playerBaseId);
        await ClearCacheAsync(playerBaseId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PlayerBase)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PlayerBase)}:{BusinessRuleConstants.AllCacheKey}");
    }
}