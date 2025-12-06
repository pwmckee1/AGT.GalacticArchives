using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface ISettlementService
{
    Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId);

    Task<HashSet<SettlementResponse>> GetSettlementsAsync(SettlementRequest request);

    Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request);

    Task DeleteSettlementAsync(Guid settlementId);
}