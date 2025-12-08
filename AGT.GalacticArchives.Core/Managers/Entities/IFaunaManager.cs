using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IFaunaManager
{
    Task<Fauna?> GetFaunaByIdAsync(Guid faunaId);

    Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request);

    Task<Fauna> UpsertFaunaAsync(Fauna request);

    Task DeleteFaunaAsync(Guid faunaId);
}