using AGT.GalacticArchives.Core.Models.Requests;
using Starship = AGT.GalacticArchives.Core.Models.GameData.Starship;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IStarshipManager
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request);

    Task<Starship> UpsertStarshipAsync(Starship request);

    Task DeleteStarshipAsync(Guid starshipId);
}