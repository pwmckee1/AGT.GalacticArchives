using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IPointOfInterestManager
{
    Task<PointOfInterest?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<HashSet<PointOfInterest>> GetPointOfInterestsAsync(PointOfInterestRequest request);

    Task<PointOfInterest> UpsertPointOfInterestAsync(PointOfInterest request);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}