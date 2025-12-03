using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class PointOfInterestManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : IPointOfInterestManager
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

        pointOfInterest.Planet =
            await entityHierarchyManager.GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId!.Value);

        return pointOfInterest;
    }

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        if (request.PointOfInterestId.HasValue)
        {
            var pointOfInterest = await GetPointOfInterestByIdAsync(request.PointOfInterestId!.Value);

            return pointOfInterest != null ? [pointOfInterest] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var pointOfInterestDocs = request.PlanetId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(PointOfInterest.PlanetId), request.PlanetId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var pointOfInterests = mapper.Map<HashSet<PointOfInterest>>(pointOfInterestDocs);

            foreach (var pointOfInterest in pointOfInterests)
            {
                pointOfInterest.Planet =
                    await entityHierarchyManager.GetPlanetWithHierarchyAsync(pointOfInterest.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request)
    {
        var updatedPointOfInterest = (PointOfInterest)await firestoreManager.UpsertAsync(request, Collection);
        updatedPointOfInterest.Planet =
            await entityHierarchyManager.GetPlanetWithHierarchyAsync(request.PlanetId!.Value);
        return updatedPointOfInterest;
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await firestoreManager.DeleteAsync(pointOfInterestId, Collection);
    }
}