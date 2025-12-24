using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IStarshipManager : IGameEntityManager
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<Starship> UpsertStarshipAsync(Starship request);

    Task<HashSet<Starship>> UpsertStarshipAsync(HashSet<Starship> request, CancellationToken ct);

    Task DeleteStarshipAsync(Guid starshipId);
}