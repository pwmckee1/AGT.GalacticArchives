using AGT.GalacticArchives.Core.Models.GameData;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IPlanetEntityManager
{
    Task<Planet> GetPlanetWithHierarchyAsync(Guid planetId);

    Task<StarSystem> GetStarSystemWithHierarchyAsync(Guid starSystemId);

    Task<Region> GetRegionWithHierarchyAsync(Guid regionId);
}