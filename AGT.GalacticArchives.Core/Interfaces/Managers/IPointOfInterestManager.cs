using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPointOfInterestManager
{
    Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request);

    Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request);

    Task<HashSet<PointOfInterest>> UpsertPointOfInterestAsync(HashSet<PointOfInterest> request, CancellationToken ct);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}