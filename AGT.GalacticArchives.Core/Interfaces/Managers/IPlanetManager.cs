using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPlanetManager
{
    Task<Planet?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<Planet>> GetPlanetsAsync(PlanetRequest request);

    Task<Planet> UpsertPlanetAsync(Planet request);

    Task<HashSet<Planet>> UpsertPlanetAsync(HashSet<Planet> request, CancellationToken ct);

    Task DeletePlanetAsync(Guid planetId);
}