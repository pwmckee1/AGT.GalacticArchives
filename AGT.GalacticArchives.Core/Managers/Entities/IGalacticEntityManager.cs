using AGT.GalacticArchives.Core.Models.DatabaseEntities;

namespace AGT.GalacticArchives.Core.Managers.Entities;

public interface IGalacticEntityManager
{
    Task<Planet> GetPlanetaryHierarchyAsync(Guid planetId);

    Task<StarSystem> GetStarSystemHierarchyAsync(Guid starSystemId);

    Task UpsertPlanetAsync(Planet? planet);

    Task UpsertStarSystemAsync(StarSystem? starSystem);

    Task UpsertRegionAsync(Region? region);
}