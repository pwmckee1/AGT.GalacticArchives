using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IStarSystemService
{
    Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<HashSet<StarSystemResponse>> GetStarSystemsAsync(StarSystemRequest request);

    Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest request);

    Task DeleteStarSystemAsync(Guid starSystemId);
}