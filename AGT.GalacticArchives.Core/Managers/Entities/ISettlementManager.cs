using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface ISettlementManager
{
    Task<Settlement?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request);

    Task<Settlement> UpsertSettlementAsync(Settlement request);

    Task DeleteSettlementAsync(Guid settlementId);
}