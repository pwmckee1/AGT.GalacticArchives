using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IStarSystemService
{
    Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<PagedResponse<StarSystemResponse>> GetStarSystemsAsync(StarSystemSearchRequest request);

    Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest request);

    Task DeleteStarSystemAsync(Guid starSystemId);
}