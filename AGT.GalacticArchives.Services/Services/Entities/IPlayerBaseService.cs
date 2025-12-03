using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IPlayerBaseService
{
    Task<PlayerBaseResponse?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<HashSet<PlayerBaseResponse>> GetPlayerBasesAsync(PlayerBaseRequest request);

    Task<PlayerBaseResponse> UpsertPlayerBaseAsync(PlayerBaseRequest request);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}