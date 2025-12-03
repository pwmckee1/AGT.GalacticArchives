using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public class PlayerBaseManager(
    IFirestoreManager firestoreManager,
    IMapper mapper,
    IEntityHierarchyManager entityHierarchyManager) : IPlayerBaseManager
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

        playerBase.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(playerBase.PlanetId!.Value);

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
            var playerBaseDocs = request.PlanetId.HasValue
                ? await firestoreManager.GetByNameAsync(request.Name, nameof(PlayerBase.PlanetId), request.PlanetId!.Value, Collection)
                : await firestoreManager.GetByNameAsync(request.Name, Collection);

            var playerBases = mapper.Map<HashSet<PlayerBase>>(playerBaseDocs);

            foreach (var playerBase in playerBases)
            {
                playerBase.Planet =
                    await entityHierarchyManager.GetPlanetWithHierarchyAsync(playerBase.PlanetId!.Value);
            }
        }

        return [];
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase request)
    {
        var updatedPlayerBase = (PlayerBase)await firestoreManager.UpsertAsync(request, Collection);
        updatedPlayerBase.Planet = await entityHierarchyManager.GetPlanetWithHierarchyAsync(request.PlanetId!.Value);
        return updatedPlayerBase;
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await firestoreManager.DeleteAsync(playerBaseId, Collection);
    }
}