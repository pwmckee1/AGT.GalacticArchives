using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGameReleaseManager
{
    Task<GameRelease?> GetGameReleaseByIdAsync(Guid gameReleaseId);

    Task<PagedDatabaseResponse> GetGameReleasesAsync(GameReleaseSearchRequest request);

    Task<GameRelease> UpsertGameReleaseAsync(GameRelease request);

    Task<HashSet<GameRelease>> UpsertGameReleaseAsync(HashSet<GameRelease> request, CancellationToken ct);

    Task DeleteGameReleaseAsync(Guid gameReleaseId);
}