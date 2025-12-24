using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface ISettlementService
{
    Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId);

    Task<PagedResponse<SettlementResponse>> GetSettlementsAsync(SettlementSearchRequest request);

    Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request);

    Task DeleteSettlementAsync(Guid settlementId);
}