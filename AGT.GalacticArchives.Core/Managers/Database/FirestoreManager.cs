using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.Database;

public class FirestoreManager(FirestoreDb firestoreDb) : IFirestoreManager
{
    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var snapshot = await firestoreDb
            .Collection(collectionName)
            .GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public virtual async Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var docRef = firestoreDb
            .Collection(collectionName)
            .Document(entityId.ToString());

        var snapshot = await docRef.GetSnapshotAsync();

        return snapshot is { Exists: true } ? snapshot.ToDictionary() : [];
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string parentIdName,
        Guid parentId,
        string collectionName)
    {
        var query = firestoreDb
            .Collection(collectionName)
            .WhereEqualTo(nameof(IDatabaseEntity.Name), entityName)
            .WhereEqualTo(parentIdName, parentId.ToString());

        var snapshot = await query.GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName)
    {
        var query = firestoreDb
            .Collection(collectionName)
            .WhereEqualTo(nameof(IDatabaseEntity.Name), entityName);

        var snapshot = await query.GetSnapshotAsync();

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public virtual async Task<IDatabaseEntity> UpsertAsync(IDatabaseEntity entity, string collectionName)
    {
        var docRef = firestoreDb
            .Collection(collectionName)
            .Document(entity.Id.ToString());

        var snapshot = await docRef.GetSnapshotAsync();

        if (!snapshot.Exists)
        {
            await docRef.SetAsync(entity.ToDictionary());
        }
        else
        {
            await docRef.UpdateAsync(entity.ToDictionary());
        }

        return entity;
    }

    public virtual async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await firestoreDb
            .Collection(collectionName)
            .Document(entityId.ToString())
            .DeleteAsync();
    }
}