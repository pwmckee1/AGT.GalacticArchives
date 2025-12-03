using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

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
        if (request.EntityId.HasValue)
        {
            var existingPlayerBase = await playerBaseManager.GetPlayerBaseByIdAsync(request.EntityId.Value);

            if (existingPlayerBase!.ToDictionary().HasAnyChanges(playerBase.ToDictionary()))
            {
                playerBase = await playerBaseManager.UpsertPlayerBaseAsync(playerBase);
            }
        }
        else
        {
            playerBase = await playerBaseManager.UpsertPlayerBaseAsync(playerBase);
        }

        return mapper.Map<PlayerBaseResponse>(playerBase);
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await playerBaseManager.DeletePlayerBaseAsync(playerBaseId);
    }
}