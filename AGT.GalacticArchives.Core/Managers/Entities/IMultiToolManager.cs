using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IMultiToolManager
{
    Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request);

    Task<MultiTool> UpsertMultiToolAsync(MultiTool request);

    Task DeleteMultiToolAsync(Guid multiToolId);
}