using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IMultiToolManager : IGameEntityManager
{
    Task<MultiTool?> GetMultiToolByIdAsync(Guid multiToolId);

    Task<MultiTool> UpsertMultiToolAsync(MultiTool request);

    Task<HashSet<MultiTool>> UpsertMultiToolAsync(HashSet<MultiTool> request, CancellationToken ct);

    Task DeleteMultiToolAsync(Guid multiToolId);
}