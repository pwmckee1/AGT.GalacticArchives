using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class SettlementService(ISettlementManager settlementManager, IMapper mapper) : ISettlementService
{
    public async Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId)
    {
        var settlement = await settlementManager.GetSettlementByIdAsync(settlementId);
        return settlement != null ? mapper.Map<SettlementResponse>(settlement) : null;
    }

    public async Task<PagedResponse<SettlementResponse>> GetSettlementsAsync(SettlementSearchRequest request)
    {
        var settlement = await settlementManager.GetAsync(request);
        return mapper.Map<PagedResponse<SettlementResponse>>(settlement);
    }

    public async Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request)
    {
        var settlement = mapper.Map<Settlement>(request);
        if (request.SettlementId.HasValue)
        {
            var existingSettlement = await settlementManager.GetSettlementByIdAsync(request.SettlementId.Value);
            if (!existingSettlement!.ToDictionary().MatchesDictionary(settlement.ToDictionary()))
            {
                var updatedSettlement = await settlementManager.UpsertSettlementAsync(settlement);
                return mapper.Map<SettlementResponse>(updatedSettlement);
            }
        }

        var newSettlement = await settlementManager.UpsertSettlementAsync(settlement);
        return mapper.Map<SettlementResponse>(newSettlement);
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await settlementManager.DeleteSettlementAsync(settlementId);
    }
}