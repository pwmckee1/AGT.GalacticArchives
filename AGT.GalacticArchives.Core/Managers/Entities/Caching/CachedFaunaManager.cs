using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities.Caching;

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

    public async Task<Fauna> UpsertFaunaAsync(Fauna fauna)
    {
        var result = await target.UpsertFaunaAsync(fauna);
        await cacheManager.SetAsync($"{nameof(Fauna)}:{fauna.FaunaId}", result, BusinessRuleConstants.DayInMinutes);
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
    }
}