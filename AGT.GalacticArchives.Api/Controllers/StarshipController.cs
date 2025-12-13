using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("starship")]
public class StarshipController(IStarshipService starshipService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<StarshipResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Starship/Starship"])]
    public async Task<IActionResult> GetAsync(StarshipRequest request)
    {
        var galaxies = await starshipService.GetStarshipsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{starshipId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<StarshipResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Starship/Starship"])]
    public async Task<IActionResult> GetAsync(Guid starshipId)
    {
        var starship = await starshipService.GetStarshipByIdAsync(starshipId);
        return Ok(starship);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<StarshipResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Starship/Starship"])]
    public async Task<IActionResult> PostAsync([FromBody] StarshipRequest starship)
    {
        var response = await starshipService.UpsertStarshipAsync(starship);
        return Ok(response);
    }

    [HttpDelete("{starshipId:guid}")]
    [SwaggerOperation(Tags = ["Starship/Starship"])]
    public async Task<IActionResult> DeleteAsync(Guid starshipId)
    {
        await starshipService.DeleteStarshipAsync(starshipId);
        return Ok();
    }
}