using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGameDataManager<T> where T : IGameData
{
    /// <summary>
    /// Retrieves all documents from a specified Firestore collection and converts them to a set of dictionaries.
    /// </summary>
    /// <param name="collectionName">
    /// The name of the Firestore collection from which documents should be retrieved.
    /// </param>
    /// <returns>
    /// A set of dictionaries, each representing a firestore db document
    /// </returns>
    Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName);

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
    Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName);

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
    Task<Dictionary<string, object>> GetByIdAsync(T entity, string collectionName);

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
    Task<T> UpsertAsync(T entity, string collectionName);

    /// <summary>
    /// Deletes a document from the specified Firestore collection based on the entity's unique identifier.
    /// </summary>
    /// <param name="entityId">
    /// The unique identifier of the entity to be deleted.
    /// </param>
    /// <param name="collectionName">
    /// The name of the Firestore collection from which the entity should be deleted.
    /// </param>
    Task DeleteAsync(Guid entityId, string collectionName);
}