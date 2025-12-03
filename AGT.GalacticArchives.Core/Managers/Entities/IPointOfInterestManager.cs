using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IPointOfInterestManager
{
    Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request);

    Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}