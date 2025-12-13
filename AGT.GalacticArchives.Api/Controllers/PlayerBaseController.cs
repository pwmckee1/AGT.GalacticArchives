using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("playerBase")]
public class PlayerBaseController(IPlayerBaseService playerBaseService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<PlayerBaseResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PlayerBase/PlayerBase"])]
    public async Task<IActionResult> GetAsync(PlayerBaseRequest request)
    {
        var galaxies = await playerBaseService.GetPlayerBasesAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{playerBaseId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<PlayerBaseResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PlayerBase/PlayerBase"])]
    public async Task<IActionResult> GetAsync(Guid playerBaseId)
    {
        var playerBase = await playerBaseService.GetPlayerBaseByIdAsync(playerBaseId);
        return Ok(playerBase);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<PlayerBaseResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PlayerBase/PlayerBase"])]
    public async Task<IActionResult> PostAsync([FromBody] PlayerBaseRequest playerBase)
    {
        var response = await playerBaseService.UpsertPlayerBaseAsync(playerBase);
        return Ok(response);
    }

    [HttpDelete("{playerBaseId:guid}")]
    [SwaggerOperation(Tags = ["PlayerBase/PlayerBase"])]
    public async Task<IActionResult> DeleteAsync(Guid playerBaseId)
    {
        await playerBaseService.DeletePlayerBaseAsync(playerBaseId);
        return Ok();
    }
}