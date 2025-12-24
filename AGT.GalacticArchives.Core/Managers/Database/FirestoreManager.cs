using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Globalization;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.Database;

public class FirestoreManager(FirestoreDb firestoreDb) : IFirestoreManager
{
    /// <summary>
    /// Retrieves paginated data from a Firestore collection based on search parameters.
    /// Automatically filters by Galaxy (defaults to Euclid if not specified).
    /// </summary>
    /// <param name="collectionName">The name of the Firestore collection to query</param>
    /// <param name="searchParameters">Dictionary of field-value pairs to filter the results</param>
    /// <param name="pageNumber">The page number to retrieve (1-based)</param>
    /// <param name="pageSize">Number of items per page</param>
    /// <param name="orderBy">The field name to sort the results by</param>
    /// <param name="ct">Cancellation token to cancel the operation</param>
    /// <returns>A PagedDatabaseResponse containing the query results and pagination information</returns>
    public async Task<PagedDatabaseResponse> GetAsync(
        string collectionName,
        Dictionary<string, string> searchParameters,
        int pageNumber,
        int pageSize,
        string? orderBy,
        CancellationToken ct = default)
    {
        // For "Get All" requests we want to, at minimum, restrict the query to a specific Galaxy.
        // Euclid by default.
        if (!searchParameters.ContainsKey(nameof(IDatabaseGameEntity.Galaxy)) &&
            searchParameters[nameof(IDatabaseGameEntity.Galaxy)] != GalaxyTypes.Euclid.GetDescription())
        {
            searchParameters.Add(nameof(IDatabaseGameEntity.Galaxy), GalaxyTypes.Euclid.GetDescription());
        }

        var collection = firestoreDb.Collection(collectionName);
        var query = string.IsNullOrEmpty(orderBy) ? collection : collection.OrderBy(orderBy);

        // Apply the other search parameters
        foreach (var searchParameter in searchParameters.Where(p =>
                     !DatabaseConstants.ExcludedQueryParameters.Contains(p.Key)))
        {
            query = query.WhereEqualTo(searchParameter.Key, searchParameter.Value);
        }

        return await query.ToPaginatedDatabaseQueryAsync(pageNumber, pageSize, ct);
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

    public async Task<HashSet<T>> UpsertAsync<T>(
        HashSet<T> entities,
        string collectionName,
        CancellationToken ct = default) where T : class, IDatabaseEntity
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