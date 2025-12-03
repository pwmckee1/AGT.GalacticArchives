using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

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
            $"{nameof(MultiTool)}:{request.EntityId}",
            async () => await target.GetMultiToolsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<MultiTool> UpsertMultiToolAsync(MultiTool multiTool)
    {
        var result = await target.UpsertMultiToolAsync(multiTool);
        await cacheManager.SetAsync($"{nameof(MultiTool)}:{multiTool.EntityId}", result, BusinessRuleConstants.DayInMinutes);
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
    }
}