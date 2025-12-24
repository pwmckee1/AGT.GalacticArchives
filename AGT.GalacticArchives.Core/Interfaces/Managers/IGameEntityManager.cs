using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGameEntityManager
{
    Task<PagedDatabaseResponse> GetAsync(BaseSearchRequest request);
}