using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IGalacticEntityManager
{
    Task<Planet?> GetPlanetaryHierarchyAsync(Guid planetId);

    Task<StarSystem?> GetStarSystemHierarchyAsync(Guid starSystemId);

    Task<Planet?> UpsertPlanetAsync(Planet? planet);

    Task<StarSystem?> UpsertStarSystemAsync(StarSystem? starSystem);

    Task<Region?> UpsertRegionAsync(Region? region);
}