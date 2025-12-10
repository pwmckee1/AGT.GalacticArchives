using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IFaunaManager
{
    Task<Fauna?> GetFaunaByIdAsync(Guid faunaId);

    Task<HashSet<Fauna>> GetFaunaAsync(FaunaRequest request);

    Task<Fauna> UpsertFaunaAsync(Fauna request);

    Task DeleteFaunaAsync(Guid faunaId);
}