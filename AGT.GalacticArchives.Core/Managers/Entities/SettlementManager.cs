using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class SettlementManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : ISettlementManager
{
    private const string Collection = DatabaseConstants.SettlementCollection;

    public async Task<Settlement?> GetSettlementByIdAsync(Guid settlementId)
    {
        var settlementDoc = await firestoreManager.GetByIdAsync(settlementId, Collection);
        var settlement = settlementDoc != null ? mapper.Map<Settlement>(settlementDoc) : null;

        if (settlement == null)
        {
            return null;
        }

        settlement.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(settlement.PlanetId!.Value);

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
            var settlementDocs = request.PlanetId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(Settlement.PlanetId), request.PlanetId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var settlements = mapper.Map<HashSet<Settlement>>(settlementDocs);

            foreach (var settlement in settlements)
            {
                settlement.Planet =
                    await entityHierarchyManager.GetPlanetWithHierarchyAsync(settlement.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement request)
    {
        var updatedSettlement = (Settlement)await firestoreManager.UpsertAsync(request, Collection);
        updatedSettlement.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(request.PlanetId!.Value);
        return updatedSettlement;
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await firestoreManager.DeleteAsync(settlementId, Collection);
    }
}