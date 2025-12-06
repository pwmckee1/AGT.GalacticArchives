using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IFaunaService
{
    Task<FaunaResponse?> GetFaunaByIdAsync(Guid faunaId);

    Task<HashSet<FaunaResponse>> GetFaunaAsync(FaunaRequest request);

    Task<FaunaResponse> UpsertFaunaAsync(FaunaRequest request);

    Task DeleteFaunaAsync(Guid faunaId);
}