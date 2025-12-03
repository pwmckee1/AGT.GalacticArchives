using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using Starship = AGT.GalacticArchives.Core.Models.GameData.Starship;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IStarshipManager
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<Starship>> GetStarshipsAsync(StarshipDatabaseEntityRequest databaseEntityRequest);

    Task<Starship> UpsertStarshipAsync(Starship starship);

    Task DeleteStarshipAsync(Guid starshipId);
}