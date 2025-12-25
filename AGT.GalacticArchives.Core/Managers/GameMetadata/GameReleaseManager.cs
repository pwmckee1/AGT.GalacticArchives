using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Metadata;
using AGT.GalacticArchives.Core.Models.Requests;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Managers.GameMetadata;

public class GameReleaseManager(IFirestoreManager firestoreManager, IMapper mapper) : IGameReleaseManager
{
    private const string Collection = DatabaseConstants.GameReleaseCollection;

    public async Task<GameRelease?> GetGameReleaseByIdAsync(Guid gameReleaseId)
    {
        var gameReleaseDoc = await firestoreManager.GetByIdAsync(gameReleaseId, Collection);
        var gameRelease = gameReleaseDoc.Count > 0 ? mapper.Map<GameRelease>(gameReleaseDoc) : null;

        return gameRelease ?? null;
    }

    public async Task<PagedDatabaseResponse> GetGameReleasesAsync(GameReleaseSearchRequest request)
    {
        var requestQuery = request.ToDictionary();

        if (requestQuery.Count > 0)
        {
            var responseDocs = await firestoreManager.GetAsync(
                Collection,
                requestQuery,
                request.PageNumber,
                request.PageSize,
                request.OrderBy);

            return responseDocs;
        }

        return new PagedDatabaseResponse();
    }

    public async Task<GameRelease> UpsertGameReleaseAsync(GameRelease request)
    {
        return await firestoreManager.UpsertAsync(request, Collection);
    }

    public async Task<HashSet<GameRelease>> UpsertGameReleaseAsync(HashSet<GameRelease> request, CancellationToken ct)
    {
        return await firestoreManager.UpsertAsync(request, Collection, ct);
    }

    public async Task DeleteGameReleaseAsync(Guid gameReleaseId)
    {
        await firestoreManager.DeleteAsync(gameReleaseId, Collection);
    }
}