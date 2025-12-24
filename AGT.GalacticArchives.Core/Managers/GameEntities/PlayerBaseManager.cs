using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public class PlayerBaseManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : GameEntityManager(firestoreManager), IPlayerBaseManager
{
    protected override string Collection => DatabaseConstants.PlayerBaseCollection;

    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var playerBaseDoc = await FirestoreManager.GetByIdAsync(playerBaseId, Collection);
        var playerBase = mapper.Map<PlayerBase>(playerBaseDoc);

        if (playerBase == null)
        {
            return null;
        }

        playerBase.Planet = playerBase.PlanetId.HasValue
            ? await galacticEntityManager.GetPlanetaryHierarchyAsync(playerBase.PlanetId!.Value)
            : null;

        return playerBase;
    }

    public async Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseSearchRequest request)
    {
        if (request.PlayerBaseId.HasValue)
        {
            var playerBase = await GetPlayerBaseByIdAsync(request.PlayerBaseId!.Value);

            return playerBase != null ? [playerBase] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            const string planetIdKey = nameof(PlayerBase.PlanetId);
            string? name = request.Name;
            var planetId = request.PlanetId!.Value;

            var playerBaseDocs = request.PlanetId.HasValue
                ? await FirestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await FirestoreManager.GetByNameAsync(request.Name, Collection);

            var playerBases = mapper.Map<HashSet<PlayerBase>>(playerBaseDocs);

            foreach (var playerBase in playerBases)
            {
                playerBase.Planet = playerBase.PlanetId.HasValue
                    ? await galacticEntityManager.GetPlanetaryHierarchyAsync(playerBase.PlanetId!.Value)
                    : null;
            }
        }

        return [];
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await FirestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task<HashSet<PlayerBase>> UpsertPlayerBaseAsync(HashSet<PlayerBase> request, CancellationToken ct)
    {
        return await FirestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await FirestoreManager.DeleteAsync(playerBaseId, Collection);
    }
}