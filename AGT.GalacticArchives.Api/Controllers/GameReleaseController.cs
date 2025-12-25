using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("game-release")]
public class GameReleaseController(IGameReleaseService gameReleaseService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResponse<GameReleaseResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["GameRelease/GameRelease"])]
    public async Task<IActionResult> GetAsync(GameReleaseSearchRequest request)
    {
        var galaxies = await gameReleaseService.GetGameReleasesAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{releaseId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<GameReleaseResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["GameRelease/GameRelease"])]
    public async Task<IActionResult> GetAsync(Guid releaseId)
    {
        var gameRelease = await gameReleaseService.GetGameReleaseByIdAsync(releaseId);
        return Ok(gameRelease);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<GameReleaseResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["GameRelease/GameRelease"])]
    public async Task<IActionResult> PostAsync([FromBody] HashSet<GameReleaseRequest> requests)
    {
        var response = await gameReleaseService.UpsertGameReleaseAsync(requests);
        return Ok(response);
    }

    [HttpDelete("{releaseId:guid}")]
    [SwaggerOperation(Tags = ["GameRelease/GameRelease"])]
    public async Task<IActionResult> DeleteAsync(Guid releaseId)
    {
        await gameReleaseService.DeleteGameReleaseAsync(releaseId);
        return Ok();
    }
}