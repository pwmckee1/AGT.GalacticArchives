using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPointOfInterestManager : IGameEntityManager
{
    Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request);

    Task<HashSet<PointOfInterest>> UpsertPointOfInterestAsync(HashSet<PointOfInterest> request, CancellationToken ct);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}