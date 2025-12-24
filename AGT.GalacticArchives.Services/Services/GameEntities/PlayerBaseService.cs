using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class PlayerBaseService(IPlayerBaseManager playerBaseManager, IMapper mapper) : IPlayerBaseService
{
    public async Task<PlayerBaseResponse?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var playerBase = await playerBaseManager.GetPlayerBaseByIdAsync(playerBaseId);
        return playerBase != null ? mapper.Map<PlayerBaseResponse>(playerBase) : null;
    }

    public async Task<PagedResponse<PlayerBaseResponse>> GetPlayerBasesAsync(PlayerBaseSearchRequest request)
    {
        var playerBase = await playerBaseManager.GetAsync(request);
        return mapper.Map<PagedResponse<PlayerBaseResponse>>(playerBase);
    }

    public async Task<PlayerBaseResponse> UpsertPlayerBaseAsync(PlayerBaseRequest request)
    {
        var playerBase = mapper.Map<PlayerBase>(request);
        if (request.PlayerBaseId.HasValue)
        {
            var existingPlayerBase = await playerBaseManager.GetPlayerBaseByIdAsync(request.PlayerBaseId.Value);
            if (!existingPlayerBase!.ToDictionary().MatchesDictionary(playerBase.ToDictionary()))
            {
                var updatedPlayerBase = await playerBaseManager.UpsertPlayerBaseAsync(playerBase);
                return mapper.Map<PlayerBaseResponse>(updatedPlayerBase);
            }
        }

        var newPlayerBase = await playerBaseManager.UpsertPlayerBaseAsync(playerBase);
        return mapper.Map<PlayerBaseResponse>(newPlayerBase);
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await playerBaseManager.DeletePlayerBaseAsync(playerBaseId);
    }
}