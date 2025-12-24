using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameEntities;

public abstract class GameEntityManager(IFirestoreManager firestoreManager) : IGameEntityManager
{
    protected readonly IFirestoreManager FirestoreManager = firestoreManager;

    protected abstract string Collection { get; }

    public virtual async Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request)
    {
        var requestQuery = request.ToDictionary();

        // For "Get All" requests we want to, at minimum, restrict the query to a specific Galaxy.
        // Euclid by default.
        if (!requestQuery.ContainsKey(nameof(IDatabaseGameEntity.Galaxy)) &&
            requestQuery[nameof(IDatabaseGameEntity.Galaxy)] != GalaxyTypes.Euclid.GetDescription())
        {
            requestQuery.Add(nameof(IDatabaseGameEntity.Galaxy), GalaxyTypes.Euclid.GetDescription());
        }

        var responseDocs = await FirestoreManager.GetAsync(
            Collection,
            requestQuery,
            request.PageNumber,
            request.PageSize,
            request.OrderBy);

        return responseDocs;
    }
}