using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IStarshipManager
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request);

    Task<Starship> UpsertStarshipAsync(Starship request);

    Task<HashSet<Starship>> UpsertStarshipAsync(HashSet<Starship> request, CancellationToken ct);

    Task DeleteStarshipAsync(Guid starshipId);
}