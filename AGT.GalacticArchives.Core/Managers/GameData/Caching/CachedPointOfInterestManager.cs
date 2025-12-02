using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Caching;

public class CachedPointOfInterestManager(ICacheManager cacheManager, IPointOfInterestManager target) : IPointOfInterestManager, ICachedGameDataManager
{
    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetPointOfInterestByIdAsync)}:{pointOfInterestId}",
            async () => await target.GetPointOfInterestByIdAsync(pointOfInterestId),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetPointOfInterestsAsync)}:{request.PointOfInterestId}:{request.PointOfInterestName}:{request.ParentId}",
            async () => await target.GetPointOfInterestsAsync(request),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest pointOfInterest)
    {
        var result = await UpsertAsync(pointOfInterest, DatabaseConstants.PointOfInterestCollection);
        return result;
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await DeleteAsync(pointOfInterestId, DatabaseConstants.PointOfInterestCollection);
    }

    public async Task<HashSet<DocumentSnapshot>> GetAllAsync(string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetAllAsync)}:{collectionName}",
            async () => await target.GetAllAsync(collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<DocumentSnapshot?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}",
            async () => await target.GetByIdAsync(entityId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, Guid parentId, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetByNameAsync)}:{entityName}:{parentId}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, parentId, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, string collectionName)
    {
        var result = await cacheManager.GetAsync(
            $"{nameof(PointOfInterest)}:{nameof(GetByNameAsync)}:{entityName}:{collectionName}",
            async () => await target.GetByNameAsync(entityName, collectionName),
            BusinessRuleConstants.DayInMinutes);
        return result!;
    }

    public async Task<PointOfInterest> UpsertAsync(PointOfInterest entity, string collectionName)
    {
        var response = await target.UpsertAsync(entity, collectionName);
        await ClearCacheAsync(entity.EntityId, collectionName);
        return response;
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await target.DeleteAsync(entityId, collectionName);
        await ClearCacheAsync(entityId, collectionName);
    }

    public async Task ClearCacheAsync(Guid entityId, string collectionName)
    {
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PointOfInterest)}:{nameof(GetPointOfInterestByIdAsync)}:{entityId}");
        await cacheManager.ClearCacheByPartialAsync($"{nameof(PointOfInterest)}:{nameof(GetByIdAsync)}:{entityId}:{collectionName}");
    }
}