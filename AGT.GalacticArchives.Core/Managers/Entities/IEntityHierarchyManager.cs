using AGT.GalacticArchives.Core.Models.Environments;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IEntityHierarchyManager
{
    Task<Planet> GetPlanetWithHierarchyAsync(Guid planetId);

    Task<StarSystem> GetStarSystemWithHierarchyAsync(Guid starSystemId);

    Task<Region> GetRegionWithHierarchyAsync(Guid regionId);
}