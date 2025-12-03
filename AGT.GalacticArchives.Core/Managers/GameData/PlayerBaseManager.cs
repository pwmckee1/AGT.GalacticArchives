using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PlayerBaseManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IStarSystemEntityManager StarSystemEntityManager) : IPlayerBaseManager
{
    private const string Collection = DatabaseConstants.PlayerBaseCollection;

    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var playerBaseDoc = await firestoreManager.GetByIdAsync(playerBaseId, Collection);
        var playerBase = playerBaseDoc != null ? mapper.Map<PlayerBase>(playerBaseDoc) : null;

        if (playerBase == null)
        {
            return null;
        }

        playerBase.Planet = await StarSystemEntityManager.GetPlanetWithHierarchyAsync(playerBase.PlanetId);

        return playerBase;
    }

    public async Task<HashSet<PlayerBase>> GetPlayerBasesAsync(PlayerBaseRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var playerBase = await GetPlayerBaseByIdAsync(request.EntityId!.Value);

            return playerBase != null ? [playerBase] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var playerBaseDocs = request.ParentId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, request.ParentId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var playerBases = mapper.Map<HashSet<PlayerBase>>(playerBaseDocs);

            foreach (var playerBase in playerBases)
            {
                playerBase.Planet = await StarSystemEntityManager.GetPlanetWithHierarchyAsync(playerBase.PlanetId);
            }
        }

        return [];
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase playerBase)
    {
        var updatedPlayerBase = (PlayerBase)await firestoreManager.UpsertAsync(playerBase, Collection);
        updatedPlayerBase.Planet = await StarSystemEntityManager.GetPlanetWithHierarchyAsync(playerBase.PlanetId);
        return updatedPlayerBase;
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await firestoreManager.DeleteAsync(playerBaseId, Collection);
    }
}