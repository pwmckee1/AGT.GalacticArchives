using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedGameReleaseServiceDecorator(IGameReleaseService gameReleaseService) : IGameReleaseService
{
    public async Task<GameReleaseResponse?> GetGameReleaseByIdAsync(Guid gameReleaseId)
    {
        return await gameReleaseService.GetGameReleaseByIdAsync(gameReleaseId);
    }

    public async Task<HashSet<GameReleaseResponse>> GetGameReleasesAsync(GameReleaseRequest request)
    {
        return await gameReleaseService.GetGameReleasesAsync(request);
    }

    public async Task<HashSet<GameReleaseResponse>> UpsertGameReleaseAsync(HashSet<GameReleaseRequest> requests)
    {
        return await gameReleaseService.UpsertGameReleaseAsync(requests);
    }

    public async Task DeleteGameReleaseAsync(Guid gameReleaseId)
    {
        await gameReleaseService.DeleteGameReleaseAsync(gameReleaseId);
    }
}