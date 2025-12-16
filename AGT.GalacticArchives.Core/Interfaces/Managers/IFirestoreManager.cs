using AGT.GalacticArchives.Core.Interfaces.Models;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IFirestoreManager
{
    Task<HashSet<Dictionary<string, object>>> GetAllAsync(string collectionName, CancellationToken ct = default);

    Task<Dictionary<string, object>> GetByIdAsync(Guid entityId, string collectionName, CancellationToken ct = default);

    Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string parentIdName,
        Guid parentId,
        string collectionName,
        CancellationToken ct = default);

    Task<HashSet<Dictionary<string, object>>> GetByNameAsync(
        string entityName,
        string collectionName,
        CancellationToken ct = default);

    Task<T> UpsertAsync<T>(T entity, string collectionName)
        where T : class, IDatabaseEntity;

    Task<HashSet<T>> UpsertAsync<T>(HashSet<T> entities, string collectionName, CancellationToken ct = default)
        where T : class, IDatabaseEntity;

    Task DeleteAsync(Guid entityId, string collectionName);
}