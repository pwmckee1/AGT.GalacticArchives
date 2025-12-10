using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Managers.InGameEntities;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Entities;

public class PlayerBaseService(IPlayerBaseManager playerBaseManager, IMapper mapper) : IPlayerBaseService
{
    public async Task<PlayerBaseResponse?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var playerBase = await playerBaseManager.GetPlayerBaseByIdAsync(playerBaseId);
        return playerBase != null ? mapper.Map<PlayerBaseResponse>(playerBase) : null;
    }

    public async Task<HashSet<PlayerBaseResponse>> GetPlayerBasesAsync(PlayerBaseRequest request)
    {
        var playerBase = await playerBaseManager.GetPlayerBasesAsync(request);
        return mapper.Map<HashSet<PlayerBaseResponse>>(playerBase);
    }

    public async Task<PlayerBaseResponse> UpsertPlayerBaseAsync(PlayerBaseRequest request)
    {
        var playerBase = mapper.Map<PlayerBase>(request);
        if (request.PlayerBaseId.HasValue)
        {
            var existingPlayerBase = await playerBaseManager.GetPlayerBaseByIdAsync(request.PlayerBaseId.Value);
            if (!existingPlayerBase!.ToDictionary().Matches(playerBase.ToDictionary()))
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