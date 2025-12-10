using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.Entities;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedPlayerBaseServiceDecorator(IPlayerBaseService playerBaseService) : IPlayerBaseService
{
    public async Task<PlayerBaseResponse?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        return await playerBaseService.GetPlayerBaseByIdAsync(playerBaseId);
    }

    public async Task<HashSet<PlayerBaseResponse>> GetPlayerBasesAsync(PlayerBaseRequest request)
    {
        return await playerBaseService.GetPlayerBasesAsync(request);
    }

    public async Task<PlayerBaseResponse> UpsertPlayerBaseAsync(PlayerBaseRequest request)
    {
        return await playerBaseService.UpsertPlayerBaseAsync(request);
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await playerBaseService.DeletePlayerBaseAsync(playerBaseId);
    }
}