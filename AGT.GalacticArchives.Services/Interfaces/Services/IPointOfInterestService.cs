using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IPointOfInterestService
{
    Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId);

    Task<PagedResponse<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestSearchRequest request);

    Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request);

    Task DeletePointOfInterestAsync(Guid pointOfInterestId);
}