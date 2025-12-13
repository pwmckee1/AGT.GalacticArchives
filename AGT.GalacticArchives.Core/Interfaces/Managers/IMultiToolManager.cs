using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IMultiToolManager
{
    Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request);

    Task<MultiTool> UpsertMultiToolAsync(MultiTool request);

    Task<HashSet<MultiTool>> UpsertMultiToolAsync(HashSet<MultiTool> request);

    Task DeleteMultiToolAsync(Guid multiToolId);
}