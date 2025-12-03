using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;

namespace AGT.GalacticArchives.Services.Services.Environments;

public interface IPlanetService
{
    Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request);

    Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request);

    Task DeletePlanetAsync(Guid planetId);
}