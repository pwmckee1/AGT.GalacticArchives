using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.GameData;

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

            if (existingPlanet!.ToDictionary().HasAnyChanges(planet.ToDictionary()))
            {
                planet = await planetManager.UpsertPlanetAsync(planet);
            }
        }
        else
        {
            planet = await planetManager.UpsertPlanetAsync(planet);
        }

        return mapper.Map<PlanetResponse>(planet);
    }

    public async Task DeletePlanetAsync(Guid planetId)
    {
        await planetManager.DeletePlanetAsync(planetId);
    }
}