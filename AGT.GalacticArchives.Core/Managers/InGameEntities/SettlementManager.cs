using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.InGameEntities;

public class SettlementManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IGalacticEntityManager galacticEntityManager) : ISettlementManager
{
    private const string Collection = DatabaseConstants.SettlementCollection;

    public async Task<Settlement?> GetSettlementByIdAsync(Guid settlementId)
    {
        var settlementDoc = await firestoreManager.GetByIdAsync(settlementId, Collection);
        var settlement = mapper.Map<Settlement>(settlementDoc);

        if (settlement == null)
        {
            return null;
        }

        settlement.Planet = settlement.PlanetId.HasValue
            ? await galacticEntityManager.GetPlanetaryHierarchyAsync(settlement.PlanetId!.Value)
            : null;

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
                ? await firestoreManager.GetByNameAsync(
                    request.Name,
                    nameof(Settlement.PlanetId),
                    request.PlanetId!.Value,
                    Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var settlements = mapper.Map<HashSet<Settlement>>(settlementDocs);

            foreach (var settlement in settlements)
            {
                settlement.Planet = settlement.PlanetId.HasValue
                    ? await galacticEntityManager.GetPlanetaryHierarchyAsync(settlement.PlanetId!.Value)
                    : null;
            }
        }

        return [];
    }

    public async Task<Settlement> UpsertSettlementAsync(Settlement request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await firestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<Settlement>> UpsertSettlementAsync(HashSet<Settlement> request, CancellationToken ct)
    {
        return await firestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteSettlementAsync(Guid settlementId)
    {
        await firestoreManager.DeleteAsync(settlementId, Collection);
    }
}