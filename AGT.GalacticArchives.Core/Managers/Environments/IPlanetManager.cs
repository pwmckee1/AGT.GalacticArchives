using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;

namespace AGT.GalacticArchives.Core.Managers.Environments;

public interface IPlanetManager
{
    Task<Planet?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request);

    Task<Planet> UpsertPlanetAsync(Planet request);

    Task DeletePlanetAsync(Guid planetId);
}