using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.InGameEntities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("fauna")]
public class FaunaController(IFaunaService faunaService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<FaunaResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Fauna/Fauna"])]
    public async Task<IActionResult> GetAsync(FaunaRequest request)
    {
        var galaxies = await faunaService.GetFaunaAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{faunaId:guid}")]
    [ProducesResponseType(typeof(MessageResponse<FaunaResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Fauna/Fauna"])]
    public async Task<IActionResult> GetAsync(Guid faunaId)
    {
        var fauna = await faunaService.GetFaunaByIdAsync(faunaId);
        return Ok(fauna);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<FaunaResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Fauna/Fauna"])]
    public async Task<IActionResult> PostAsync([FromBody] FaunaRequest fauna)
    {
        var response = await faunaService.UpsertFaunaAsync(fauna);
        return Ok(response);
    }

    [HttpDelete("{faunaId:guid}")]
    [SwaggerOperation(Tags = ["Fauna/Fauna"])]
    public async Task<IActionResult> DeleteAsync(Guid faunaId)
    {
        await faunaService.DeleteFaunaAsync(faunaId);
        return Ok();
    }
}