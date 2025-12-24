using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedFaunaServiceDecorator(IFaunaService faunaService) : IFaunaService
{
    public async Task<FaunaResponse?> GetFaunaByIdAsync(Guid faunaId)
    {
        return await faunaService.GetFaunaByIdAsync(faunaId);
    }

    public async Task<PagedResponse<FaunaResponse>> GetFaunaAsync(FaunaSearchRequest request)
    {
        return await faunaService.GetFaunaAsync(request);
    }

    public async Task<FaunaResponse> UpsertFaunaAsync(FaunaRequest request)
    {
        return await faunaService.UpsertFaunaAsync(request);
    }

    public async Task DeleteFaunaAsync(Guid faunaId)
    {
        await faunaService.DeleteFaunaAsync(faunaId);
    }
}