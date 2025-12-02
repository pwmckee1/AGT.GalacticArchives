using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class PlayerBaseManager(FirestoreDb firestoreDb, IMapper mapper) : GameDataManager<PlayerBase>(firestoreDb, mapper), IPlayerBaseManager
{
    public async Task<PlayerBase?> GetPlayerBaseByIdAsync(Guid playerBaseId)
    {
        var snapshot = await GetByIdAsync(playerBaseId, DatabaseConstants.PlayerBaseCollection);

        var playerBase = Mapper.Map<PlayerBase>(snapshot);

        playerBase.Planet = await GetPlanetWithHierarchyAsync(playerBase.PlanetId);

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
            var snapshots = request.ParentId.HasValue
                ? await GetByNameAsync(request.Name!, request.ParentId!.Value, DatabaseConstants.PlayerBaseCollection)
                : await GetByNameAsync(request.Name!, DatabaseConstants.PlayerBaseCollection);

            var playerBaseSet = Mapper.Map<HashSet<PlayerBase>>(snapshots);
            foreach (var playerBase in playerBaseSet)
            {
                playerBase.Planet = await GetPlanetWithHierarchyAsync(playerBase.PlanetId);

            }

            return playerBaseSet;
        }

        return [];
    }

    public async Task<PlayerBase> UpsertPlayerBaseAsync(PlayerBase playerBase)
    {
        return await UpsertAsync(playerBase, DatabaseConstants.PlayerBaseCollection);
    }

    public async Task DeletePlayerBaseAsync(Guid playerBaseId)
    {
        await DeleteAsync(playerBaseId, DatabaseConstants.PlayerBaseCollection);
    }
}