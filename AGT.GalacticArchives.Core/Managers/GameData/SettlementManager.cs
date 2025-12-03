using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class SettlementManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IInnerSystemEntityManager innerSystemEntityManager) : ISettlementManager
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

        settlement.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(settlement.PlanetId!.Value);

        return settlement;
    }

    public async Task<HashSet<Settlement>> GetSettlementsAsync(SettlementRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var settlement = await GetSettlementByIdAsync(request.EntityId!.Value);

            return settlement != null ? [settlement] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var settlementDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var settlements = mapper.Map<HashSet<Settlement>>(settlementDocs);

            foreach (var settlement in settlements)
            {
                settlement.Planet =
                    await innerSystemEntityManager.GetPlanetWithHierarchyAsync(settlement.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement request)
    {
        var updatedSettlement = (Settlement)await firestoreManager.UpsertAsync(request, Collection);
        updatedSettlement.Planet = await innerSystemEntityManager.GetPlanetWithHierarchyAsync(request.PlanetId!.Value);
        return updatedSettlement;
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await firestoreManager.DeleteAsync(settlementId, Collection);
    }
}