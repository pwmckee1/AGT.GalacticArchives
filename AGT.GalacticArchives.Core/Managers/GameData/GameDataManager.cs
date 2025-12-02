using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public abstract class GameDataManager<T>(FirestoreDb firestoreDb, IMapper mapper)
    : IGameDataManager<T> where T : IGameData
{
    protected readonly FirestoreDb FirestoreDb = firestoreDb;
    protected readonly IMapper Mapper = mapper;

    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var snapshot = await FirestoreDb.Collection(collectionName)
            .GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : snapshot.Documents.Select(s => s.ToDictionary()).ToHashSet();
    }

    public virtual async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var docRef = FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString());

        var snapshot = await docRef.GetSnapshotAsync();

        return snapshot != null && snapshot.Exists ? snapshot.ToDictionary() : null;
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        Guid parentId,
        string collectionName)
    {
        var query = FirestoreDb
            .Collection(collectionName)
            .WhereEqualTo(nameof(Models.GameData.GameData.Name), entityName)
            .WhereEqualTo(nameof(Models.GameData.GameData.ParentId), parentId.ToString());

        var snapshot = await query.GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : snapshot.Documents.Select(s => s.ToDictionary()).ToHashSet();
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var query = FirestoreDb
            .Collection(collectionName)
            .WhereEqualTo(nameof(Models.GameData.GameData.Name), entityName);

        var snapshot = await query.GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : snapshot.Documents.Select(s => s.ToDictionary()).ToHashSet();
    }

    public virtual async Task<T> UpsertAsync(T entity, string collectionName)
    {
        var docRef = FirestoreDb.Collection(entity.CollectionName)
            .Document(entity.EntityId.ToString());

        var snapshot = await docRef.GetSnapshotAsync();

        if (!snapshot.Exists)
            await docRef.SetAsync(entity.ToDictionary());
        else
            await docRef.UpdateAsync(entity.ToDictionary());

        return entity;
    }

    public virtual async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString())
            .DeleteAsync();
    }

    protected async Task<Planet> GetPlanetWithHierarchyAsync(Guid planetId)
    {
        var planetData = await GetByIdAsync(planetId, DatabaseConstants.PlanetCollection);

        var planet = Mapper.Map<Planet>(planetData);

        planet.StarSystem = await GetStarSystemWithHierarchyAsync(planet.StarSystemId);

        return planet;
    }

    protected async Task<StarSystem> GetStarSystemWithHierarchyAsync(Guid starSystemId)
    {
        var starSystemData = await GetByIdAsync(starSystemId, DatabaseConstants.StarSystemCollection);

        var starSystem = Mapper.Map<StarSystem>(starSystemData);

        starSystem.Region = await GetRegionWithHierarchyAsync(starSystem.RegionId);

        return starSystem;
    }

    protected async Task<Region> GetRegionWithHierarchyAsync(Guid regionId)
    {
        var regionData = await GetByIdAsync(regionId, DatabaseConstants.RegionCollection);

        var region = Mapper.Map<Region>(regionData);

        var galaxyData = await GetByIdAsync(region.GalaxyId, DatabaseConstants.GalaxyCollection);

        region.Galaxy = Mapper.Map<Galaxy>(galaxyData);

        return region;
    }
}