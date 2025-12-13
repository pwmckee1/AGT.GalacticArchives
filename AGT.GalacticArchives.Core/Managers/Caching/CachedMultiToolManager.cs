using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

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

    public async Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(MultiTool)}:{request.MultiToolId}",
            async () => await target.GetMultiToolsAsync(request),
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

    public async Task<HashSet<MultiTool>> UpsertMultiToolAsync(HashSet<MultiTool> request)
    {
        var result = await target.UpsertMultiToolAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(MultiTool)}:{BusinessRuleConstants.AllCacheKey}",
            result,
            BusinessRuleConstants.DayInMinutes);
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