using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AGT.GalacticArchives.Services.Services.Environments;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("galaxy")]
public class GalaxyController(IGalaxyService galaxyService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<GalaxyResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Galaxy/Galaxy"])]
    public async Task<IActionResult> GetAsync(GalaxyRequest request)
    {
        var galaxies = await galaxyService.GetGalaxiesAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{galaxyId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<GalaxyResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Galaxy/Galaxy"])]
    public async Task<IActionResult> GetAsync(Guid galaxyId)
    {
        var galaxy = await galaxyService.GetGalaxyByIdAsync(galaxyId);
        return Ok(galaxy);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<GalaxyResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Galaxy/Galaxy"])]
    public async Task<IActionResult> PostAsync([FromBody] GalaxyRequest galaxy)
    {
        var response = await galaxyService.UpsertGalaxyAsync(galaxy);
        return Ok(response);
    }

    [HttpDelete("{galaxyId:guid}")]
    [SwaggerOperation(Tags = ["Galaxy/Galaxy"])]
    public async Task<IActionResult> DeleteAsync(Guid galaxyId)
    {
        await galaxyService.DeleteGalaxyAsync(galaxyId);
        return Ok();
    }
}