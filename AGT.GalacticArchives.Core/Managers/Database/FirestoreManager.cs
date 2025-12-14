using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Globalization;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.Database;

public class FirestoreManager(FirestoreDb firestoreDb) : IFirestoreManager
{
    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(
        string collectionName,
        CancellationToken ct = default)
    {
        var snapshot = await firestoreDb.Collection(collectionName).GetSnapshotAsync(ct);

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public async Task<Dictionary<string, object>> GetByIdAsync(
        Guid entityId,
        string collectionName,
        CancellationToken ct = default)
    {
        var docRef = firestoreDb.Collection(collectionName).Document(entityId.ToString());

        var snapshot = await docRef.GetSnapshotAsync(ct);

        return snapshot is { Exists: true } ? snapshot.ToDictionary() : [];
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string parentIdName,
        Guid parentId,
        string collectionName,
        CancellationToken ct = default)
    {
        var query = firestoreDb
            .Collection(collectionName)
            .WhereEqualTo(nameof(IDatabaseEntity.Name), entityName)
            .WhereEqualTo(parentIdName, parentId.ToString());

        var snapshot = await query.GetSnapshotAsync(ct);

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public async Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string collectionName,
        CancellationToken ct = default)
    {
        var query = firestoreDb.Collection(collectionName).WhereEqualTo(nameof(IDatabaseEntity.Name), entityName);

        var snapshot = await query.GetSnapshotAsync(ct);

        return snapshot.Documents.Count == 0 ? [] : [.. snapshot.Documents.Select(s => s.ToDictionary())];
    }

    public async Task<T> UpsertAsync<T>(T entity, string collectionName) where T : class, IDatabaseEntity
    {
        if (entity.EntityId == Guid.Empty)
        {
            throw new InvalidOperationException(string.Format(GeneralErrorResource.EntityIdMissing, typeof(T).Name));
        }

        var docRef = firestoreDb.Collection(collectionName).Document(entity.EntityId.ToString());

        await docRef.SetAsync(entity.ToDictionary(), SetOptions.MergeAll);

        return entity;
    }

    public async Task<HashSet<T>> UpsertAsync<T>(HashSet<T> entities, string collectionName, CancellationToken ct = default)
        where T : class, IDatabaseEntity
    {
        // Firestore batch limit is 500 writes, but gRPC message size can be hit earlier.
        const int maxWritesPerBatch = 250;

        var batch = firestoreDb.StartBatch();
        int writesInBatch = 0;

        foreach (var gameEntity in entities)
        {
            ct.ThrowIfCancellationRequested();
            if (gameEntity.EntityId == Guid.Empty)
            {
                throw new InvalidOperationException(
                    string.Format(GeneralErrorResource.EntityIdMissing, typeof(T).Name));
            }

            var docRef = firestoreDb.Collection(collectionName).Document(gameEntity.EntityId.ToString());

            var gameEntityRef = gameEntity.ToDictionary();
            batch.Set(docRef, gameEntityRef, SetOptions.MergeAll);
            writesInBatch++;

            if (writesInBatch >= maxWritesPerBatch)
            {
                await batch.CommitAsync(ct);
                batch = firestoreDb.StartBatch();
                writesInBatch = 0;
            }
        }

        if (writesInBatch > 0)
        {
            await batch.CommitAsync(ct);
        }

        return entities;
    }

    public async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await firestoreDb.Collection(collectionName).Document(entityId.ToString()).DeleteAsync();
    }
}