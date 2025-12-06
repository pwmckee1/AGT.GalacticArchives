using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.Entities;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Entities;

public class SettlementService(ISettlementManager settlementManager, IMapper mapper) : ISettlementService
{
    public async Task<SettlementResponse?> GetSettlementByIdAsync(Guid settlementId)
    {
        var settlement = await settlementManager.GetSettlementByIdAsync(settlementId);
        return settlement != null ? mapper.Map<SettlementResponse>(settlement) : null;
    }

    public async Task<HashSet<SettlementResponse>> GetSettlementsAsync(SettlementRequest request)
    {
        var settlement = await settlementManager.GetSettlementsAsync(request);
        return mapper.Map<HashSet<SettlementResponse>>(settlement);
    }

    public async Task<SettlementResponse> UpsertSettlementAsync(SettlementRequest request)
    {
        var settlement = mapper.Map<Settlement>(request);
        if (request.SettlementId.HasValue)
        {
            var existingSettlement = await settlementManager.GetSettlementByIdAsync(request.SettlementId.Value);
            if (!existingSettlement!.ToDictionary().Matches(settlement.ToDictionary()))
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