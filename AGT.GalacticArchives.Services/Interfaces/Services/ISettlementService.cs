using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface ISettlementService
{
    Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<SettlementResponse>> GetSettlementsAsync(SettlementRequest request);

    Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request);

    Task DeleteSettlementAsync(Guid settlementId);
}