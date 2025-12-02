using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedMultiToolServiceDecorator(IMultiToolService multiToolService) : IMultiToolService
{
    public async Task<MultiToolResponse?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        return await multiToolService.GetMultiToolByIdAsync(multiToolId);
    }

    public async Task<HashSet<MultiToolResponse>> GetMultiToolsAsync(MultiToolRequest request)
    {
        return await multiToolService.GetMultiToolsAsync(request);
    }

    public async Task<MultiToolResponse> UpsertMultiToolAsync(MultiToolRequest request)
    {
        return await multiToolService.UpsertMultiToolAsync(request);
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await multiToolService.DeleteMultiToolAsync(multiToolId);
    }
}