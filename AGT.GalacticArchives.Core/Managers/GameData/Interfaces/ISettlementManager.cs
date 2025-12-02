using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface ISettlementManager : IGameDataManager<Settlement>
{
    Task<Settlement?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request);

    Task<Settlement> UpsertSettlementAsync(Settlement settlement);

    Task DeleteSettlementAsync(Guid settlementId);
}