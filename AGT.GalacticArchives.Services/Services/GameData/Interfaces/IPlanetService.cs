using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;

namespace AGT.GalacticArchives.Services.Services.GameData.Interfaces;

public interface IPlanetService
{
    Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId);

    Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request);

    Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest planet);

    Task DeletePlanetAsync(Guid planetId);
}