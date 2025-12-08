using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.Entities;
using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Entities;

public class MultiToolService(IMultiToolManager multiToolManager, IMapper mapper) : IMultiToolService
{
    public async Task<MultiToolResponse?> GetMultiToolByIdAsync(Guid multiToolId)
    {
        var multiTool = await multiToolManager.GetMultiToolByIdAsync(multiToolId);
        return multiTool != null ? mapper.Map<MultiToolResponse>(multiTool) : null;
    }

    public async Task<HashSet<MultiToolResponse>> GetMultiToolsAsync(MultiToolRequest request)
    {
        var multiTool = await multiToolManager.GetMultiToolsAsync(request);
        return mapper.Map<HashSet<MultiToolResponse>>(multiTool);
    }

    public async Task<MultiToolResponse> UpsertMultiToolAsync(MultiToolRequest request)
    {
        var multiTool = mapper.Map<MultiTool>(request);
        if (request.MultiToolId.HasValue)
        {
            var existingMultiTool = await multiToolManager.GetMultiToolByIdAsync(request.MultiToolId.Value);
            if (!existingMultiTool!.ToDictionary().Matches(multiTool.ToDictionary()))
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