using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class PointOfInterestService(IPointOfInterestManager pointOfInterestManager, IMapper mapper)
    : IPointOfInterestService
{
    public async Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var pointOfInterest = await pointOfInterestManager.GetPointOfInterestByIdAsync(pointOfInterestId);
        return pointOfInterest != null ? mapper.Map<PointOfInterestResponse>(pointOfInterest) : null;
    }

    public async Task<PagedResponse<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestSearchRequest request)
    {
        var pointOfInterest = await pointOfInterestManager.GetAsync(request);
        return mapper.Map<PagedResponse<PointOfInterestResponse>>(pointOfInterest);
    }

    public async Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request)
    {
        var pointOfInterest = mapper.Map<PointOfInterest>(request);
        if (request.PointOfInterestId.HasValue)
        {
            var existingPointOfInterest = await pointOfInterestManager.GetPointOfInterestByIdAsync(request.PointOfInterestId.Value);
            if (existingPointOfInterest!.ToDictionary().MatchesDictionary(pointOfInterest.ToDictionary()))
            {
                var updatedPointOfInterest = await pointOfInterestManager.UpsertPointOfInterestAsync(pointOfInterest);
                return mapper.Map<PointOfInterestResponse>(updatedPointOfInterest);
            }
        }

        var newPointOfInterest = await pointOfInterestManager.UpsertPointOfInterestAsync(pointOfInterest);
        return mapper.Map<PointOfInterestResponse>(newPointOfInterest);
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await pointOfInterestManager.DeletePointOfInterestAsync(pointOfInterestId);
    }
}