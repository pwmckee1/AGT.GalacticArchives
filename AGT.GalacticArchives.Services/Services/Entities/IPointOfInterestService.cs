using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IPointOfInterestService
{
    Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<HashSet<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestRequest request);

    Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}