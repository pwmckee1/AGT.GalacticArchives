using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.Environments;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Environments;

public class PlanetService(IPlanetManager planetManager, IMapper mapper) : IPlanetService
{
    public async Task<PlanetResponse?> GetPlanetByIdAsync(Guid planetId)
    {
        var planet = await planetManager.GetPlanetByIdAsync(planetId);
        return planet != null ? mapper.Map<PlanetResponse>(planet) : null;
    }

    public async Task<HashSet<PlanetResponse>> GetPlanetsAsync(PlanetRequest request)
    {
        var planet = await planetManager.GetPlanetsAsync(request);
        return mapper.Map<HashSet<PlanetResponse>>(planet);
    }

    public async Task<PlanetResponse> UpsertPlanetAsync(PlanetRequest request)
    {
        var planet = mapper.Map<Planet>(request);
        if (request.PlanetId.HasValue)
        {
            var existingPlanet = await planetManager.GetPlanetByIdAsync(request.PlanetId.Value);
            if (!existingPlanet!.ToDictionary().Matches(planet.ToDictionary()))
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