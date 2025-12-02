using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface IStarSystemService
{
    Task<StarSystemResponse?> GetStarSystemByIdAsync(Guid starSystemId);

    Task<HashSet<StarSystemResponse>> GetStarSystemsAsync(StarSystemRequest request);

    Task<StarSystemResponse> UpsertStarSystemAsync(StarSystemRequest starSystem);

    Task DeleteStarSystemAsync(Guid starSystemId);
}