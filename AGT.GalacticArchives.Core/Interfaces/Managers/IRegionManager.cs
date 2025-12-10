using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IRegionManager
{
    Task<Region?> GetRegionByIdAsync(Guid regionId);

    Task<HashSet<Region>> GetRegionsAsync(RegionRequest request);

    Task<Region> UpsertRegionAsync(Region request);

    Task DeleteRegionAsync(Guid regionId);
}