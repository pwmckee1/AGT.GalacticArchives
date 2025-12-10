using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IMultiToolService
{
    Task<MultiToolResponse?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<HashSet<MultiToolResponse>> GetMultiToolsAsync(MultiToolRequest request);

    Task<MultiToolResponse> UpsertMultiToolAsync(MultiToolRequest request);

    Task DeleteMultiToolAsync(Guid multiToolId);
}