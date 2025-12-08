using AGT.GalacticArchives.Core.Models.Requests.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Entities;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IPlanetService
{
    Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request);

    Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request);

    Task DeletePlanetAsync(Guid planetId);
}