using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IStarshipManager : IGameDataManager<Starship>
{
    Task<Starship?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<Starship>> GetStarshipsAsync(StarshipRequest request);

    Task<Starship> UpsertStarshipAsync(Starship starship);

    Task DeleteStarshipAsync(Guid starshipId);
}