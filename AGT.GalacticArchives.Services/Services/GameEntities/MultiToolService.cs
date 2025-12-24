using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class MultiToolService(IMultiToolManager multiToolManager, IMapper mapper) : IMultiToolService
{
    public async Task<MultiToolResponse?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var multiTool = await multiToolManager.GetMultiToolByIdAsync(multiToolId);
        return multiTool != null ? mapper.Map<MultiToolResponse>(multiTool) : null;
    }

    public async Task<PagedResponse<MultiToolResponse>> GetMultiToolsAsync(MultiToolSearchRequest request)
    {
        var multiTool = await multiToolManager.GetAsync(request);
        return mapper.Map<PagedResponse<MultiToolResponse>>(multiTool);
    }

    public async Task<MultiToolResponse> UpsertMultiToolAsync(MultiToolRequest request)
    {
        var multiTool = mapper.Map<MultiTool>(request);
        if (request.MultiToolId.HasValue)
        {
            var existingMultiTool = await multiToolManager.GetMultiToolByIdAsync(request.MultiToolId.Value);
            if (!existingMultiTool!.ToDictionary().MatchesDictionary(multiTool.ToDictionary()))
            {
                var updatedMultiTool = await multiToolManager.UpsertMultiToolAsync(multiTool);
                return mapper.Map<MultiToolResponse>(updatedMultiTool);
            }
        }

        var newMultiTool = await multiToolManager.UpsertMultiToolAsync(multiTool);
        return mapper.Map<MultiToolResponse>(newMultiTool);
    }

    public async Task DeleteMultiToolAsync(Guid multiToolId)
    {
        await multiToolManager.DeleteMultiToolAsync(multiToolId);
    }
}