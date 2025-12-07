using AGT.GalacticArchives.Core.Models.Entities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IGalacticEntityManager
{
    Task<Planet> GetPlanetaryHierarchyAsync(Guid planetId);

    Task<StarSystem> GetSolarHierarchyAsync(Guid starSystemId);

    Task<Region> GetRegionalHierarchyAsync(Guid regionId);

    Task UpsertPlanetAsync(Planet? planet);

    Task UpsertStarSystemAsync(StarSystem? starSystem);

    Task UpsertRegionAsync(Region? region);
}