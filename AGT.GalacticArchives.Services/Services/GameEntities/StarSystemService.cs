using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class StarSystemService(IStarSystemManager starSystemManager, IMapper mapper) : IStarSystemService
{
    public async Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystem = await starSystemManager.GetStarSystemByIdAsync(starSystemId);
        return starSystem != null ? mapper.Map<StarSystemResponse>(starSystem) : null;
    }

    public async Task<PagedResponse<StarSystemResponse>> GetStarSystemsAsync(StarSystemSearchRequest request)
    {
        var starSystems = await starSystemManager.GetAsync(request);
        return mapper.Map<PagedResponse<StarSystemResponse>>(starSystems);
    }

    public async Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest request)
    {
        var starSystem = mapper.Map<StarSystem>(request);
        if (request.StarSystemId.HasValue)
        {
            var existingStarSystem = await starSystemManager.GetStarSystemByIdAsync(request.StarSystemId.Value);
            if (!existingStarSystem!.ToDictionary().MatchesDictionary(starSystem.ToDictionary()))
            {
                var updatedStarSystem = await starSystemManager.UpsertStarSystemAsync(starSystem);
                return mapper.Map<StarSystemResponse>(updatedStarSystem);
            }
        }

        var newStarSystem = await starSystemManager.UpsertStarSystemAsync(starSystem);
        return mapper.Map<StarSystemResponse>(newStarSystem);
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await starSystemManager.DeleteStarSystemAsync(starSystemId);
    }
}