using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AGT.GalacticArchives.Services.Services.Entities;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedPointOfInterestServiceDecorator(IPointOfInterestService pointOfInterestService)
    : IPointOfInterestService
{
    public async Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        return await pointOfInterestService.GetPointOfInterestByIdAsync(pointOfInterestId);
    }

    public async Task<HashSet<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        return await pointOfInterestService.GetPointOfInterestsAsync(request);
    }

    public async Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request)
    {
        return await pointOfInterestService.UpsertPointOfInterestAsync(request);
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await pointOfInterestService.DeletePointOfInterestAsync(pointOfInterestId);
    }
}