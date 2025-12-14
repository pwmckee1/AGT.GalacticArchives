using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedFaunaManager(ICacheManager cacheManager, IFaunaManager target)
    : IFaunaManager, ICachedGameDataManager
{
    public async Task<Fauna?> GetFaunaByIdAsync(Guid faunaId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{faunaId}",
            async () => await target.GetFaunaByIdAsync(faunaId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(Fauna)}:{request.FaunaId}",
            async () => await target.GetFaunaAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<Fauna> UpsertFaunaAsync(Fauna request)
    {
        var result = await target.UpsertFaunaAsync(request);
        await cacheManager.SetAsync($"{nameof(Fauna)}:{request.FaunaId}", result, BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<Fauna>> UpsertFaunaAsync(HashSet<Fauna> request, CancellationToken ct)
    {
        var result = await target.UpsertFaunaAsync(request, ct);
        var faunaIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var faunaId in faunaIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(Fauna)}:{faunaId}");
        }

        return result;
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await target.DeleteFaunaAsync(faunaId);
        await ClearCacheAsync(faunaId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(Fauna)}:{BusinessRuleConstants.AllCacheKey}");
    }
}