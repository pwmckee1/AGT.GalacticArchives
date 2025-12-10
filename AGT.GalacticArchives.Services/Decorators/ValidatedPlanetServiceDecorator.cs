using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.Environments;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedPlanetServiceDecorator(IPlanetService planetService) : IPlanetService
{
    public async Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId)
    {
        return await planetService.GetPlanetByIdAsync(planetId);
    }

    public async Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request)
    {
        return await planetService.GetPlanetsAsync(request);
    }

    public async Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request)
    {
        return await planetService.UpsertPlanetAsync(request);
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await planetService.DeletePlanetAsync(planetId);
    }
}