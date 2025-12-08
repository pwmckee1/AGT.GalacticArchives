using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities.Caching;

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

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{request.PointOfInterestId}",
            async () => await target.GetPointOfInterestsAsync(request),
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

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await target.DeletePointOfInterestAsync(pointOfInterestId);
        await ClearCacheAsync(pointOfInterestId);
    }

    public async Task ClearCacheAsync(Guid entityId)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PointOfInterest)}:{entityId}");
    }
}