using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IPlayerBaseManager
{
    Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request);

    Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}