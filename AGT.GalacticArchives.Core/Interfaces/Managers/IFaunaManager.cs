using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IFaunaManager : IGameEntityManager
{
    Task<Fauna?> GetFaunaByIdAsync(Guid faunaId);

    Task<Fauna> UpsertFaunaAsync(Fauna request);

    Task<HashSet<Fauna>> UpsertFaunaAsync(HashSet<Fauna> request, CancellationToken ct);

    Task DeleteFaunaAsync(Guid faunaId);
}