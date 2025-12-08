using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class PointOfInterestManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : IPointOfInterestManager
{
    private const string Collection = DatabaseConstants.PointOfInterestCollection;

    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var pointOfInterestDoc = await firestoreManager.GetByIdAsync(pointOfInterestId, Collection);
        var pointOfInterest = mapper.Map<PointOfInterest>(pointOfInterestDoc);

        if (pointOfInterest == null)
        {
            return null;
        }

        pointOfInterest.Planet =
            await galacticEntityManager.GetPlanetaryHierarchyAsync(pointOfInterest.PlanetId!.Value);

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
            const string planetIdKey = nameof(PointOfInterest.PlanetId);
            string? name = request.Name;
            var planetId = request.PlanetId!.Value;

            var pointOfInterestDocs = request.PlanetId.HasValue
                ? await firestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var pointOfInterests = mapper.Map<HashSet<PointOfInterest>>(pointOfInterestDocs);

            foreach (var pointOfInterest in pointOfInterests)
            {
                pointOfInterest.Planet =
                    await galacticEntityManager.GetPlanetaryHierarchyAsync(pointOfInterest.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await firestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await firestoreManager.DeleteAsync(pointOfInterestId, Collection);
    }
}