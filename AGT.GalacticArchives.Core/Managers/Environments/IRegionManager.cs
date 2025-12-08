using AGT.GalacticArchives.Core.Models.DatabaseEntities;
using AGT.GalacticArchives.Core.Models.Requests.Entities;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public interface IRegionManager
{
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<Region>> GetRegionsAsync(RegionRequest request);

    Task<Region> UpsertRegionAsync(Region request);

    Task DeleteRegionAsync(Guid regionId);
}