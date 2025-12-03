using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IPlayerBaseManager
{
    Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request);

    Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase playerBase);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}