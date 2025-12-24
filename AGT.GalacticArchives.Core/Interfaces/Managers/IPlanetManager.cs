using AGT.GalacticArchives.Core.Models.GameEntities;

namespace AGT.GalacticArchives.Core.Interfaces.Managers;

public interface IPlanetManager : IGameEntityManager
{
    Task<Planet?> GetPlanetByIdAsync(Guid planetId);

    Task<Planet> UpsertPlanetAsync(Planet request);

    Task<HashSet<Planet>> UpsertPlanetAsync(HashSet<Planet> request, CancellationToken ct);

    Task DeletePlanetAsync(Guid planetId);
}