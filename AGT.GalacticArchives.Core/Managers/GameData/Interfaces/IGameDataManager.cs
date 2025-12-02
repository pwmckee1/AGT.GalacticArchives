using AGT.GalacticArchives.Core.Models.GameData.Interfaces;
using Google.Cloud.Firestore;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IGameDataManager<T> where T : IGameData
{
    Task<HashSet<DocumentSnapshot>> GetAllAsync(string collectionName);

    Task<DocumentSnapshot?> GetByIdAsync(Guid entityId, string collectionName);

    Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, Guid parentId, string collectionName);

    Task<HashSet<DocumentSnapshot>> GetByNameAsync(string entityName, string collectionName);

    Task<T> UpsertAsync(T entity, string collectionName);

    Task DeleteAsync(Guid entityId, string collectionName);
}