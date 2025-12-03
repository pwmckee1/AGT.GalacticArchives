using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("planet")]
public class PlanetController(IPlanetService planetService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<PlanetResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Planet/Planet"])]
    public async Task<IActionResult> GetAsync(PlanetRequest request)
    {
        var galaxies = await planetService.GetPlanetsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{planetId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<PlanetResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Planet/Planet"])]
    public async Task<IActionResult> GetAsync(Guid planetId)
    {
        var planet = await planetService.GetPlanetByIdAsync(planetId);
        return Ok(planet);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<PlanetResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Planet/Planet"])]
    public async Task<IActionResult> PostAsync([FromBody] PlanetRequest planet)
    {
        var response = await planetService.UpsertPlanetAsync(planet);
        return Ok(response);
    }

    [HttpDelete("{planetId:guid}")]
    [SwaggerOperation(Tags = ["Planet/Planet"])]
    public async Task<IActionResult> DeleteAsync(Guid planetId)
    {
        await planetService.DeletePlanetAsync(planetId);
        return Ok();
    }
}