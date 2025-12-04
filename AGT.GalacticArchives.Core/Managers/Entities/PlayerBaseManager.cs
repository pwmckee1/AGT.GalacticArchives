using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class PlayerBaseManager(
    IFirestoreManager firestoreManager,
    IGalacticEntityManager galacticEntityManager,
    IMapper mapper) : IPlayerBaseManager
{
    private const string Collection = DatabaseConstants.PlayerBaseCollection;

    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var playerBaseDoc = await firestoreManager.GetByIdAsync(playerBaseId, Collection);
        var playerBase = mapper.Map<PlayerBase>(playerBaseDoc);

        if (playerBase == null)
        {
            return null;
        }

        playerBase.Planet = await galacticEntityManager.GetPlanetaryHierarchyAsync(playerBase.PlanetId!.Value);

        return playerBase;
    }

    public async Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request)
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
                ? await firestoreManager.GetByNameAsync(name, planetIdKey, planetId, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var playerBases = mapper.Map<HashSet<PlayerBase>>(playerBaseDocs);

            foreach (var playerBase in playerBases)
            {
                playerBase.Planet =
                    await galacticEntityManager.GetPlanetaryHierarchyAsync(playerBase.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request)
    {
        await galacticEntityManager.UpsertPlanetAsync(request.Planet);
        await galacticEntityManager.UpsertStarSystemAsync(request.Planet?.StarSystem);
        await galacticEntityManager.UpsertRegionAsync(request.Planet?.StarSystem?.Region);
        await firestoreManager.UpsertAsync(request, Collection);
        return request;
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await firestoreManager.DeleteAsync(playerBaseId, Collection);
    }
}