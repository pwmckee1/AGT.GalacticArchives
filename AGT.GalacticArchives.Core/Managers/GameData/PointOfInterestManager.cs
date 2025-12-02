using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PointOfInterestManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<PointOfInterest>(firestoreDb, mapper), IPointOfInterestManager
{
    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var snapshot = await GetByIdAsync(pointOfInterestId, DatabaseConstants.PointOfInterestCollection);

        var pointOfInterest = Mapper.Map<PointOfInterest>(snapshot);

        pointOfInterest.Planet = await GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId);

        return pointOfInterest;
    }

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        if (request.PointOfInterestId.HasValue)
        {
            var pointOfInterest = await GetPointOfInterestByIdAsync(request.PointOfInterestId!.Value);

            return pointOfInterest != null ? [pointOfInterest] : [];
        }

        if (!string.IsNullOrEmpty(request.PointOfInterestName))
        {
            var snapshots =  request.ParentId.HasValue
                ? GetByNameAsync(request.PointOfInterestName!, request.ParentId!.Value, DatabaseConstants.PointOfInterestCollection)
                : GetByNameAsync(request.PointOfInterestName!, DatabaseConstants.PointOfInterestCollection);

            var pointOfInterestSet = Mapper.Map<HashSet<PointOfInterest>>(snapshots);
            foreach (var pointOfInterest in pointOfInterestSet)
            {
                pointOfInterest.Planet = await GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId);

            }

            return pointOfInterestSet;
        }

        return [];
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest pointOfInterest)
    {
        return await UpsertAsync(pointOfInterest, DatabaseConstants.PointOfInterestCollection);
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await DeleteAsync(pointOfInterestId, DatabaseConstants.PointOfInterestCollection);
    }
}