using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IStarshipService
{
    Task<StarshipResponse?> GetStarshipByIdAsync(Guid starshipId);

    Task<HashSet<StarshipResponse>> GetStarshipsAsync(StarshipRequest request);

    Task<StarshipResponse> UpsertStarshipAsync(StarshipRequest request);

    Task DeleteStarshipAsync(Guid starshipId);
}