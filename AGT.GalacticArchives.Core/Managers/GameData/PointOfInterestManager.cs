using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PointOfInterestManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IPlanetEntityManager planetEntityManager) : IPointOfInterestManager
{
    private const string Collection = DatabaseConstants.PointOfInterestCollection;

    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var pointOfInterestDoc = await firestoreManager.GetByIdAsync(pointOfInterestId, Collection);
        var pointOfInterest = pointOfInterestDoc != null ? mapper.Map<PointOfInterest>(pointOfInterestDoc) : null;

        if (pointOfInterest == null)
        {
            return null;
        }

        pointOfInterest.Planet = await planetEntityManager.GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId);

        return pointOfInterest;
    }

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var pointOfInterest = await GetPointOfInterestByIdAsync(request.EntityId!.Value);

            return pointOfInterest != null ? [pointOfInterest] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var pointOfInterestDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var pointOfInterests = mapper.Map<HashSet<PointOfInterest>>(pointOfInterestDocs);

            foreach (var pointOfInterest in pointOfInterests)
            {
                pointOfInterest.Planet = await planetEntityManager.GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId);
            }
        }

        return [];
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest pointOfInterest)
    {
        var updatedPointOfInterest = (PointOfInterest)await firestoreManager.UpsertAsync(pointOfInterest, Collection);
        updatedPointOfInterest.Planet = await planetEntityManager.GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId);
        return updatedPointOfInterest;
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await firestoreManager.DeleteAsync(pointOfInterestId, Collection);
    }
}