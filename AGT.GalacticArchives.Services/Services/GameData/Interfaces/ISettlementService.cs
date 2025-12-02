using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface ISettlementService
{
    Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<SettlementResponse>> GetSettlementsAsync(SettlementRequest request);

    Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest settlement);

    Task DeleteSettlementAsync(Guid settlementId);
}