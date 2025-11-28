using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AutoMapper;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData;

public abstract class GameDataManager<T>(FirestoreDb firestoreDb, IMapper mapper) : IGameDataManager<T> where T : IGameData
{
    protected readonly FirestoreDb FirestoreDb = firestoreDb;
    protected readonly IMapper Mapper = mapper;

    public virtual async Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName)
    {
        var docRef = FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString());

        if (docRef == null)
        {
            return new Dictionary<string, object>();
        }

        var snapshot = await docRef.GetSnapshotAsync();

        return !snapshot.Exists ? null : snapshot.ToDictionary();
    }

    public virtual async Task<Dictionary<string, object>?> GetByIdAsync(T entity, string collectionName)
    {
        return await GetByIdAsync(entity.EntityId, collectionName);
    }

    public virtual async Task CreateOrUpdateAsync(T entity, string collectionName)
    {
        var docRef = FirestoreDb.Collection(collectionName)
            .Document(entity.EntityId.ToString());

        var snapshot = await docRef.GetSnapshotAsync();

        if (!snapshot.Exists)
        {
            await docRef.SetAsync(entity.ToDictionary());
        }
        else
        {
            await docRef.UpdateAsync(entity.ToDictionary());
        }
    }

    public virtual async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString())
            .DeleteAsync();
    }
}