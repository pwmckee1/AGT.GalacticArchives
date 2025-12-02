using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IMultiToolManager : IGameDataManager<MultiTool>
{
    Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<HashSet<MultiTool>> GetMultiToolsAsync(MultiToolRequest request);

    Task<MultiTool> UpsertMultiToolAsync(MultiTool multiTool);

    Task DeleteMultiToolAsync(Guid multiToolId);
}