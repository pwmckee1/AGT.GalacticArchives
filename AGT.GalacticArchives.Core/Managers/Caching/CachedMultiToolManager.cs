using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedMultiToolManager(ICacheManager cacheManager, IMultiToolManager target)
    : IMultiToolManager, ICachedGameDataManager
{
    public async Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{multiToolId}",
            async () => await target.GetMultiToolByIdAsync(multiToolId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as MultiToolSearchRequest);
        string cacheKey = $"{nameof(MultiTool)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool request)
    {
        var result = await target.UpsertMultiToolAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(MultiTool)}:{request.MultiToolId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<MultiTool>> UpsertMultiToolAsync(HashSet<MultiTool> request, CancellationToken ct)
    {
        var result = await target.UpsertMultiToolAsync(request, ct);
        var multiToolIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var multiToolId in multiToolIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(MultiTool)}:{multiToolId}");
        }

        return result;
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await target.DeleteMultiToolAsync(multiToolId);
        await ClearCacheAsync(multiToolId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(MultiTool)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(MultiTool)}:{BusinessRuleConstants.AllCacheKey}");
    }
}