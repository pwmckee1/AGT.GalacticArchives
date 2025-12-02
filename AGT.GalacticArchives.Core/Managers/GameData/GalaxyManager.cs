using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public class GalaxyManager(FirestoreDb firestoreDb, IMapper mapper)
    : GameDataManager<Galaxy>(firestoreDb, mapper), IGalaxyManager
{
    public async Task<HashSet<Galaxy>> GetGalaxiesAsync()
    {
        var data = await GetAllAsync(DatabaseConstants.GalaxyCollection);
        return Mapper.Map<HashSet<Galaxy>>(data);
    }

    public async Task<Galaxy?> GetGalaxyByIdAsync(Guid galaxyId)
    {
        var snapshot = await GetByIdAsync(galaxyId, DatabaseConstants.GalaxyCollection);
        return snapshot != null ? Mapper.Map<Galaxy>(snapshot.ToDictionary()) : null;
    }

    public async Task<HashSet<Galaxy>> GetGalaxiesAsync(GalaxyRequest request)
    {
        if (request.EntityId.HasValue)
        {
            var galaxy = await GetGalaxyByIdAsync(request.EntityId!.Value);
            return galaxy != null ? [galaxy] : [];
        }

        if (!string.IsNullOrEmpty(request.Name))
        {
            var snapshots = await GetByNameAsync(request.Name, DatabaseConstants.GalaxyCollection);

            return Mapper.Map<HashSet<Galaxy>>(snapshots);
        }

        return [];
    }

    public async Task<Galaxy> UpsertGalaxyAsync(Galaxy galaxy)
    {
        return await UpsertAsync(galaxy, DatabaseConstants.GalaxyCollection);
    }

    public async Task DeleteGalaxyAsync(Guid galaxyId)
    {
        await DeleteAsync(galaxyId, DatabaseConstants.GalaxyCollection);
    }
}