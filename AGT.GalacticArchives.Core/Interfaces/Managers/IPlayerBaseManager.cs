using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPlayerBaseManager
{
    Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request);

    Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}