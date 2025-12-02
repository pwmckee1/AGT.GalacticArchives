using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface IFaunaService
{
    Task<FaunaResponse?> GetFaunaByIdAsync(Guid faunaId);

    Task<HashSet<FaunaResponse>> GetFaunaAsync(FaunaRequest request);

    Task<FaunaResponse> UpsertFaunaAsync(FaunaRequest request);

    Task DeleteFaunaAsync(Guid faunaId);
}