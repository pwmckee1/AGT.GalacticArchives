using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

public class StarSystemService(IStarSystemManager starSystemManager, IMapper mapper) : IStarSystemService
{
    public async Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId)
    {
        var starSystem = await starSystemManager.GetStarSystemByIdAsync(starSystemId);
        return starSystem != null ? mapper.Map<StarSystemResponse>(starSystem) : null;
    }

    public async Task<HashSet<StarSystemResponse>> GetStarSystemsAsync(StarSystemRequest request)
    {
        var starSystem = await starSystemManager.GetStarSystemsAsync(request);
        return mapper.Map<HashSet<StarSystemResponse>>(starSystem);
    }

    public async Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest request)
    {
        var starSystem = mapper.Map<StarSystem>(request);
        if (request.EntityId.HasValue)
        {
            var existingStarSystem = await starSystemManager.GetStarSystemByIdAsync(request.EntityId.Value);

            if (existingStarSystem!.ToDictionary().HasAnyChanges(starSystem.ToDictionary()))
            {
                starSystem = await starSystemManager.UpsertStarSystemAsync(starSystem);
            }
        }
        else
        {
            starSystem = await starSystemManager.UpsertStarSystemAsync(starSystem);
        }

        return mapper.Map<StarSystemResponse>(starSystem);
    }

    public async Task DeleteStarSystemAsync(Guid starSystemId)
    {
        await starSystemManager.DeleteStarSystemAsync(starSystemId);
    }
}