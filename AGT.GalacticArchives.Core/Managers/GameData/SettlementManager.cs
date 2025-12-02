using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class SettlementManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<Settlement>(firestoreDb, mapper), ISettlementManager
{
    public async Task<Settlement?> GetSettlementByIdAsync(Guid settlementId)
    {
        var snapshot = await GetByIdAsync(settlementId, DatabaseConstants.SettlementCollection);

        var settlement = Mapper.Map<Settlement>(snapshot);

        settlement.Planet = await GetPlanetWithHierarchyAsync(settlement.PlanetId);

        return settlement;
    }

    public async Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request)
    {
        if (request.SettlementId.HasValue)
        {
            var settlement = await GetSettlementByIdAsync(request.SettlementId!.Value);

            return settlement != null ? [settlement] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = request.ParentId.HasValue
                ? GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.SettlementCollection)
                : GetByNameAsync(request.Name!, DatabaseConstants.SettlementCollection);

            var settlementSet = Mapper.Map<HashSet<Settlement>>(snapshots);
            foreach (var settlement in settlementSet)
                settlement.Planet = await GetPlanetWithHierarchyAsync(settlement.PlanetId);

            return settlementSet;
        }

        return [];
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement settlement)
    {
        return await UpsertAsync(settlement, DatabaseConstants.SettlementCollection);
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await DeleteAsync(settlementId, DatabaseConstants.SettlementCollection);
    }
}