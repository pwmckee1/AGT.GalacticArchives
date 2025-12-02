using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Managers.GameData.Interfaces;

public interface IPlanetManager : IGameDataManager<Planet>
{
    Task<Planet?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request);

    Task<Planet> UpsertPlanetAsync(Planet planet);

    Task DeletePlanetAsync(Guid planetId);
}