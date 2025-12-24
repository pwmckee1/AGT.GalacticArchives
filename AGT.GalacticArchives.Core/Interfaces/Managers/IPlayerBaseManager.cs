using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPlayerBaseManager : IGameEntityManager
{
    Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId);

    Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request);

    Task<HashSet<PlayerBase>> UpsertPlayerBaseAsync(HashSet<PlayerBase> request, CancellationToken ct);

    Task DeletePlayerBaseAsync(Guid playerBaseId);
}