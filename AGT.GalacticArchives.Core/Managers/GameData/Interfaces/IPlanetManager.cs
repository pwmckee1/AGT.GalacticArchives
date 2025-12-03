using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IPlanetManager
{
    Task<Planet?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request);

    Task<Planet> UpsertPlanetAsync(Planet request);

    Task DeletePlanetAsync(Guid planetId);
}