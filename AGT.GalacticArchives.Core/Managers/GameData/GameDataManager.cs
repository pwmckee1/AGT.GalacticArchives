using AGT.GalacticArchives.Core.Interfaces.GameData;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AutoMapper;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace AGT.GalacticArchives.Core.Managers.GameData;

/// <summary>
/// Abstract base class for managing game data entities in a Firestore database.
/// </summary>
/// <typeparam name="T">
/// The type of the game data entity, constrained to implement the <see cref="IGameData"/> interface.
/// </typeparam>
public abstract class GameDataManager<T>(FirestoreDb firestoreDb, IMapper mapper)
    : IGameDataManager<T> where T : IGameData
{
    protected readonly FirestoreDb FirestoreDb = firestoreDb;
    protected readonly IMapper Mapper = mapper;

    /// <summary>
    /// Retrieves all documents from a specified Firestore collection and converts them to a set of dictionaries.
    /// </summary>
    /// <param name="collectionName">
    /// The name of the Firestore collection from which documents should be retrieved.
    /// </param>
    /// <returns>
    /// A set of dictionaries, each representing a firestore db document
    /// </returns>
    public async Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName)
    {
        var snapshot = await FirestoreDb.Collection(collectionName)
            .GetSnapshotAsync();

        return snapshot.Documents
            .Select(d => d.ToDictionary())
            .ToHashSet();
    }

    /// <summary>
    /// Retrieves a specific document from a Firestore collection based on the entity ID and converts it to a dictionary
    /// </summary>
    /// <param name="entityId">
    /// The unique identifier of the entity to be retrieved.
    /// </param>
    /// <param name="collectionName">
    /// The Firestore collection name that contains the desired document.
    /// </param>
    /// <returns>
    /// A dictionary representing the Firestore document. Returns an empty dictionary if the document is not found.
    /// </returns>
    public virtual async Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName)
    {
        var docRef = FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString());

        if (docRef == null)
        {
            return new Dictionary<string, object>();
        }

        var snapshot = await docRef.GetSnapshotAsync();

        return snapshot == null || !snapshot.Exists ? new Dictionary<string, object>() : snapshot.ToDictionary();
    }

    /// <summary>
    /// Retrieves a specific document from a Firestore collection based on the entity ID and converts it to a dictionary
    /// </summary>
    /// <param name="entity">
    /// The entity containing the unique identifier to retrieve from the Firestore collection.
    /// </param>
    /// <param name="collectionName">
    /// The Firestore collection name that contains the desired document.
    /// </param>
    /// <returns>
    /// A dictionary representing the Firestore document. Returns an empty dictionary if the document is not found.
    /// </returns>
    ///
    public virtual async Task<Dictionary<string, object>> GetByIdAsync(T entity, string collectionName)
    {
        return await GetByIdAsync(entity.EntityId, collectionName);
    }

    /// <summary>
    /// Inserts or updates an entity in the specified Firestore collection.
    /// </summary>
    /// <param name="entity">
    /// The entity to be inserted or updated in the Firestore collection.
    /// </param>
    /// <param name="collectionName">
    /// The name of the Firestore collection where the entity should be stored.
    /// </param>
    /// <returns>
    /// The entity after it has been inserted or updated in the Firestore collection.
    /// </returns>
    public virtual async Task<T> UpsertAsync(T entity, string collectionName)
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

        return entity;
    }

    /// <summary>
    /// Deletes a document from the specified Firestore collection based on the entity's unique identifier.
    /// </summary>
    /// <param name="entityId">
    /// The unique identifier of the entity to be deleted.
    /// </param>
    /// <param name="collectionName">
    /// The name of the Firestore collection from which the entity should be deleted.
    /// </param>
    public virtual async Task DeleteAsync(Guid entityId, string collectionName)
    {
        await FirestoreDb.Collection(collectionName)
            .Document(entityId.ToString())
            .DeleteAsync();
    }
}