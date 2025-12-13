using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface ISettlementManager
{
    Task<Settlement?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request);

    Task<Settlement> UpsertSettlementAsync(Settlement request);

    Task<HashSet<Settlement>> UpsertSettlementAsync(HashSet<Settlement> request);

    Task DeleteSettlementAsync(Guid settlementId);
}