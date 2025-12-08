using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IStarshipManager
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request);

    Task<Starship> UpsertStarshipAsync(Starship request);

    Task DeleteStarshipAsync(Guid starshipId);
}