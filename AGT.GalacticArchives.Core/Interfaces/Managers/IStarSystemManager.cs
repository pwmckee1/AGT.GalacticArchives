using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IStarSystemManager : IGameEntityManager
{
    Task<StarSystem?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<StarSystem> UpsertStarSystemAsync(StarSystem starSystem);

    Task<HashSet<StarSystem>> UpsertStarSystemAsync(HashSet<StarSystem> request, CancellationToken ct);

    Task DeleteStarSystemAsync(Guid starSystemId);
}