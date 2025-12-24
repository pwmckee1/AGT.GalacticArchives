using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IPlanetService
{
    Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request);

    Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request);

    Task DeletePlanetAsync(Guid planetId);
}