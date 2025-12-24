using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IStarshipService
{
    Task<StarshipResponse?> GetStarshipByIdAsync(Guid starshipId);

    Task<PagedResponse<StarshipResponse>> GetStarshipsAsync(StarshipSearchRequest request);

    Task<StarshipResponse> UpsertStarshipAsync(StarshipRequest request);

    Task DeleteStarshipAsync(Guid starshipId);
}