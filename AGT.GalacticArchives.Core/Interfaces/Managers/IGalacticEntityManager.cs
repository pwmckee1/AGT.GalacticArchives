using AGT.GalacticArchives.Core.Models.InGame.Locations;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGalacticEntityManager
{
    Task<Planet> GetPlanetaryHierarchyAsync(Guid planetId);

    Task<StarSystem> GetStarSystemHierarchyAsync(Guid starSystemId);

    Task UpsertPlanetAsync(Planet? planet);

    Task UpsertStarSystemAsync(StarSystem? starSystem);

    Task UpsertRegionAsync(Region? region);
}