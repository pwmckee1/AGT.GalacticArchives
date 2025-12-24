using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IFaunaService
{
    Task<FaunaResponse?> GetFaunaByIdAsync(Guid faunaId);

    Task<PagedResponse<FaunaResponse>> GetFaunaAsync(FaunaSearchRequest request);

    Task<FaunaResponse> UpsertFaunaAsync(FaunaRequest request);

    Task DeleteFaunaAsync(Guid faunaId);
}