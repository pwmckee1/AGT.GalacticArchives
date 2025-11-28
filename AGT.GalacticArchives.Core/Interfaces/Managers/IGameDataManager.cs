using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGameDataManager<in T> where T : IGameData
{
    Task<Dictionary<string, object>?> GetByIdAsync(Guid entityId, string collectionName);

    Task<Dictionary<string, object>?> GetByIdAsync(T entity, string collectionName);

    Task CreateOrUpdateAsync(T entity, string collectionName);

    Task DeleteAsync(Guid entityId, string collectionName);
}