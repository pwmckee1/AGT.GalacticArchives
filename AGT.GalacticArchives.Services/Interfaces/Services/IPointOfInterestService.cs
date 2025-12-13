using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IPointOfInterestService
{
    Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<HashSet<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestRequest request);

    Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}