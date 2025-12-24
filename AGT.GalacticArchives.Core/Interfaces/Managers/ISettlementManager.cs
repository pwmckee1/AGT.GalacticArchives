using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface ISettlementManager : IGameEntityManager
{
    Task<Settlement?> GetSettlementByIdAsync(Guid settlementId);

    Task<Settlement> UpsertSettlementAsync(Settlement request);

    Task<HashSet<Settlement>> UpsertSettlementAsync(HashSet<Settlement> request, CancellationToken ct);

    Task DeleteSettlementAsync(Guid settlementId);
}