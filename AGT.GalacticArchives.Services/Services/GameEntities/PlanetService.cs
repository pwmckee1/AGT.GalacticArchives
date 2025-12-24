using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameEntities;

public class PlanetService(IPlanetManager planetManager, IMapper mapper) : IPlanetService
{
    public async Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId)
    {
        var planet = await planetManager.GetPlanetByIdAsync(planetId);
        return planet != null ? mapper.Map<PlanetResponse>(planet) : null;
    }

    public async Task<PagedResponse<PlanetResponse>> GetPlanetsAsync(PlanetSearchRequest request)
    {
        var planet = await planetManager.GetAsync(request);
        return mapper.Map<PagedResponse<PlanetResponse>>(planet);
    }

    public async Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request)
    {
        var planet = mapper.Map<Planet>(request);
        if (request.PlanetId.HasValue)
        {
            var existingPlanet = await planetManager.GetPlanetByIdAsync(request.PlanetId.Value);
            if (!existingPlanet!.ToDictionary().MatchesDictionary(planet.ToDictionary()))
            {
                var updatedPlanet = await planetManager.UpsertPlanetAsync(planet);
                return mapper.Map<PlanetResponse>(updatedPlanet);
            }
        }

        var newPlanet = await planetManager.UpsertPlanetAsync(planet);
        return mapper.Map<PlanetResponse>(newPlanet);
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await planetManager.DeletePlanetAsync(planetId);
    }
}