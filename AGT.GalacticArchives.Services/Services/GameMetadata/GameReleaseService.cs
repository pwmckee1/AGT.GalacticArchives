using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameMetadata;

public class GameReleaseService(IGameReleaseManager gameReleaseManager, IMapper mapper) : IGameReleaseService
{
    public async Task<GameReleaseResponse?> GetGameReleaseByIdAsync(Guid gameReleaseId)
    {
        var gameRelease = await gameReleaseManager.GetGameReleaseByIdAsync(gameReleaseId);
        return gameRelease != null ? mapper.Map<GameReleaseResponse>(gameRelease) : null;
    }

    public async Task<PagedResponse<GameReleaseResponse>> GetGameReleasesAsync(GameReleaseRequest request)
    {
        var gameRelease = await gameReleaseManager.GetGameReleasesAsync(request);
        return mapper.Map<PagedResponse<GameReleaseResponse>>(gameRelease);
    }

    public async Task<HashSet<GameReleaseResponse>> UpsertGameReleaseAsync(HashSet<GameReleaseRequest> requests)
    {
        var gameReleases = new HashSet<GameRelease>();
        foreach (var gameReleaseRequest in requests)
        {
            var gameRelease = mapper.Map<GameRelease>(gameReleaseRequest);
            if (gameReleaseRequest.ReleaseId.HasValue)
            {
                var existingGameRelease = await gameReleaseManager.GetGameReleaseByIdAsync(gameReleaseRequest.ReleaseId.Value);
                if (!existingGameRelease!.ToDictionary().MatchesDictionary(gameRelease.ToDictionary()))
                {
                    var updatedGameRelease = await gameReleaseManager.UpsertGameReleaseAsync(gameRelease);
                    gameReleases.Add(updatedGameRelease);
                }
            }

            var newGameRelease = await gameReleaseManager.UpsertGameReleaseAsync(gameRelease);
            gameReleases.Add(newGameRelease);
        }

        return mapper.Map<HashSet<GameReleaseResponse>>(gameReleases);
    }

    public async Task DeleteGameReleaseAsync(Guid gameReleaseId)
    {
        await gameReleaseManager.DeleteGameReleaseAsync(gameReleaseId);
    }
}