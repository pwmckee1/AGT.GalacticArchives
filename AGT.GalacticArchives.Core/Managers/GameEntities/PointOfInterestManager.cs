using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class PointOfInterestManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : GameEntityManager(firestoreManager), IPointOfInterestManager
{
    protected override string Collection => DatabaseConstants.PointOfInterestCollection;

    public async Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var pointOfInterestDoc = await FirestoreManager.GetByIdAsync(pointOfInterestId, Collection);
        var pointOfInterest = mapper.Map<PointOfInterest>(pointOfInterestDoc);

        if (pointOfInterest == null)
        {
            return null;
        }

        pointOfInterest.Planet = pointOfInterest.PlanetId.HasValue
            ? await galacticEntityManager.GetPlanetaryHierarchyAsync(pointOfInterest.PlanetId!.Value)
            : null;

        return pointOfInterest;
    }

    public async Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestSearchRequest request)
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
                ? await FirestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await FirestoreManager.GetByNameAsync(request.Name, Collection);

            var pointOfInterests = mapper.Map<HashSet<PointOfInterest>>(pointOfInterestDocs);

            foreach (var pointOfInterest in pointOfInterests)
            {
                pointOfInterest.Planet = pointOfInterest.PlanetId.HasValue
                    ? await galacticEntityManager.GetPlanetaryHierarchyAsync(pointOfInterest.PlanetId!.Value)
                    : null;
            }
        }

        return [];
    }

    public async Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await FirestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<PointOfInterest>> UpsertPointOfInterestAsync(
        HashSet<PointOfInterest> request,
        CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await FirestoreManager.DeleteAsync(pointOfInterestId, Collection);
    }
}