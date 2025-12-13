using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("multiTool")]
public class MultiToolController(IMultiToolService multiToolService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<MultiToolResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["MultiTool/MultiTool"])]
    public async Task<IActionResult> GetAsync(MultiToolRequest request)
    {
        var galaxies = await multiToolService.GetMultiToolsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{multiToolId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<MultiToolResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["MultiTool/MultiTool"])]
    public async Task<IActionResult> GetAsync(Guid multiToolId)
    {
        var multiTool = await multiToolService.GetMultiToolByIdAsync(multiToolId);
        return Ok(multiTool);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<MultiToolResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["MultiTool/MultiTool"])]
    public async Task<IActionResult> PostAsync([FromBody] MultiToolRequest multiTool)
    {
        var response = await multiToolService.UpsertMultiToolAsync(multiTool);
        return Ok(response);
    }

    [HttpDelete("{multiToolId:guid}")]
    [SwaggerOperation(Tags = ["MultiTool/MultiTool"])]
    public async Task<IActionResult> DeleteAsync(Guid multiToolId)
    {
        await multiToolService.DeleteMultiToolAsync(multiToolId);
        return Ok();
    }
}