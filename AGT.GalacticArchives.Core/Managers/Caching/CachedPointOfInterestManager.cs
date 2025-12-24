using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.Caching;

public class CachedPointOfInterestManager(ICacheManager cacheManager, IPointOfInterestManager target)
    : IPointOfInterestManager, ICachedGameDataManager
{
    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{pointOfInterestId}",
            async () => await target.GetPointOfInterestByIdAsync(pointOfInterestId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        string serializedRequest = JsonConvert.SerializeObject(request as PointOfInterestSearchRequest);
        string cacheKey = $"{nameof(PointOfInterest)}s:{serializedRequest}";
        var result = await cacheManager.GetAsync(
            cacheKey,
            async () => await target.GetAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request)
    {
        var result = await target.UpsertPointOfInterestAsync(request);
        await cacheManager.SetAsync(
            $"{nameof(PointOfInterest)}:{request.PointOfInterestId}",
            result,
            BusinessRuleConstants.DayInMinutes);
        return result;
    }

    public async Task<HashSet<PointOfInterest>> UpsertPointOfInterestAsync(
        HashSet<PointOfInterest> request,
        CancellationToken ct)
    {
        var result = await target.UpsertPointOfInterestAsync(request, ct);
        var pointOfInterestIds = result.Select(r => r.EntityId).ToHashSet();

        foreach (var pointOfInterestId in pointOfInterestIds)
        {
            await cacheManager.ClearCacheByKeyAsync($"{nameof(PointOfInterest)}:{pointOfInterestId}");
        }

        return result;
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await target.DeletePointOfInterestAsync(pointOfInterestId);
        await ClearCacheAsync(pointOfInterestId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PointOfInterest)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PointOfInterest)}:{BusinessRuleConstants.AllCacheKey}");
    }
}