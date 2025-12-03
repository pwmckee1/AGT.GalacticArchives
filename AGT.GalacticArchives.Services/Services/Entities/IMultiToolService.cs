using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Entities;

public interface IMultiToolService
{
    Task<MultiToolResponse?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<HashSet<MultiToolResponse>> GetMultiToolsAsync(MultiToolRequest request);

    Task<MultiToolResponse> UpsertMultiToolAsync(MultiToolRequest request);

    Task DeleteMultiToolAsync(Guid multiToolId);
}