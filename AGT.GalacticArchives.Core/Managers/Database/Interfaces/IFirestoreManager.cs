using AGT.GalacticArchives.Core.Models.GameData.Interfaces;

namespace AGT.GalacticArchives.Core.Managers.Database.Interfaces;

public interface IFirestoreManager
{
    Task<HashSet<Dictionary<string, object?>>> GetAllAsync(string collectionName);

    Task<Dictionary<string, object?>?> GetByIdAsync(Guid entityId, string collectionName);

    Task<HashSet<Dictionary<string, object?>>> GetByNameAsync(string entityName, Guid parentId, string collectionName);

    Task<HashSet<Dictionary<string, object?>>> GetByNameAsync(string entityName, string collectionName);

    Task<IDatabaseEntity> UpsertAsync(IDatabaseEntity entity, string collectionName);

    Task DeleteAsync(Guid entityId, string collectionName);
}