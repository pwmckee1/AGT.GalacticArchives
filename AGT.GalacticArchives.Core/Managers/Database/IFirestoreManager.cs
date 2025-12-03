using AGT.GalacticArchives.Core.Models;

namespace AGT.GalacticArchives.Core.Managers.Database;

public interface IFirestoreManager
{
    Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName);

    Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName);

    Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string parentIdName,
        Guid parentId,
        string collectionName);

    Task<HashSet<Dictionary<string, object>>> GetByNameAsync(string entityName, string collectionName);

    Task<IGameData> UpsertAsync(IGameData entity, string collectionName);

    Task DeleteAsync(Guid entityId, string collectionName);
}