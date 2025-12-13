using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IPlayerBaseService
{
    Task<PlayerBaseResponse?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<HashSet<PlayerBaseResponse>> GetPlayerBasesAsync(PlayerBaseRequest request);

    Task<PlayerBaseResponse> UpsertPlayerBaseAsync(PlayerBaseRequest request);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}