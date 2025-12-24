using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IGameReleaseService
{
    Task<GameReleaseResponse?> GetGameReleaseByIdAsync(Guid gameReleaseId);

    Task<PagedResponse<GameReleaseResponse>> GetGameReleasesAsync(GameReleaseRequest request);

    Task<HashSet<GameReleaseResponse>> UpsertGameReleaseAsync(HashSet<GameReleaseRequest> requests);

    Task DeleteGameReleaseAsync(Guid gameReleaseId);
}