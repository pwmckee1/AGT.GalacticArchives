using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public interface IRegionManager
{
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<Region>> GetRegionsAsync(RegionRequest request);

    Task<Region> UpsertRegionAsync(Region request);

    Task DeleteRegionAsync(Guid regionId);
}