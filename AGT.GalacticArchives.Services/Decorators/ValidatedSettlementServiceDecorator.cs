using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.Entities;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedSettlementServiceDecorator(ISettlementService settlementService) : ISettlementService
{
    public async Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId)
    {
        return await settlementService.GetSettlementByIdAsync(settlementId);
    }

    public async Task<HashSet<SettlementResponse>> GetSettlementsAsync(SettlementRequest request)
    {
        return await settlementService.GetSettlementsAsync(request);
    }

    public async Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request)
    {
        return await settlementService.UpsertSettlementAsync(request);
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await settlementService.DeleteSettlementAsync(settlementId);
    }
}