using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IRegionManager : IGameEntityManager
{
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    Task<Region> UpsertRegionAsync(Region request);

    Task<HashSet<Region>> UpsertRegionAsync(HashSet<Region> request, CancellationToken ct);

    Task DeleteRegionAsync(Guid regionId);
}