using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("star-system")]
public class StarSystemController(IStarSystemService starSystemService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<StarSystemResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["StarSystem/StarSystem"])]
    public async Task<IActionResult> GetAsync(StarSystemRequest request)
    {
        var galaxies = await starSystemService.GetStarSystemsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{starSystemId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<StarSystemResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["StarSystem/StarSystem"])]
    public async Task<IActionResult> GetAsync(Guid starSystemId)
    {
        var starSystem = await starSystemService.GetStarSystemByIdAsync(starSystemId);
        return Ok(starSystem);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<StarSystemResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["StarSystem/StarSystem"])]
    public async Task<IActionResult> PostAsync([FromBody] StarSystemRequest starSystem)
    {
        var response = await starSystemService.UpsertStarSystemAsync(starSystem);
        return Ok(response);
    }

    [HttpDelete("{starSystemId:guid}")]
    [SwaggerOperation(Tags = ["StarSystem/StarSystem"])]
    public async Task<IActionResult> DeleteAsync(Guid starSystemId)
    {
        await starSystemService.DeleteStarSystemAsync(starSystemId);
        return Ok();
    }
}