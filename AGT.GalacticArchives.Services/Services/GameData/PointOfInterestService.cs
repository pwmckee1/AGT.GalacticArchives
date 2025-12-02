using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class PointOfInterestService(IPointOfInterestManager pointOfInterestManager, IMapper mapper)
    : IPointOfInterestService
{
    public async Task<PointOfInterestResponse?> GetPointOfInterestByIdAsync(Guid pointOfInterestId)
    {
        var pointOfInterest = await pointOfInterestManager.GetPointOfInterestByIdAsync(pointOfInterestId);
        return pointOfInterest != null ? mapper.Map<PointOfInterestResponse>(pointOfInterest) : null;
    }

    public async Task<HashSet<PointOfInterestResponse>> GetPointOfInterestsAsync(PointOfInterestRequest request)
    {
        var pointOfInterest = await pointOfInterestManager.GetPointOfInterestsAsync(request);
        return mapper.Map<HashSet<PointOfInterestResponse>>(pointOfInterest);
    }

    public async Task<PointOfInterestResponse> UpsertPointOfInterestAsync(PointOfInterestRequest request)
    {
        var pointOfInterest = mapper.Map<PointOfInterest>(request);
        if (request.PointOfInterestId.HasValue)
        {
            var existingPointOfInterest =
                await pointOfInterestManager.GetPointOfInterestByIdAsync(request.PointOfInterestId.Value);

            if (existingPointOfInterest!.ToDictionary().HasAnyChanges(pointOfInterest.ToDictionary()))
                pointOfInterest = await pointOfInterestManager.UpsertPointOfInterestAsync(pointOfInterest);
        }
        else
        {
            pointOfInterest = await pointOfInterestManager.UpsertPointOfInterestAsync(pointOfInterest);
        }

        return mapper.Map<PointOfInterestResponse>(pointOfInterest);
    }

    public async Task DeletePointOfInterestAsync(Guid pointOfInterestId)
    {
        await pointOfInterestManager.DeletePointOfInterestAsync(pointOfInterestId);
    }
}