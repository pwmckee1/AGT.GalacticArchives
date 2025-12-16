using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("poi")]
public class PointOfInterestController(IPointOfInterestService pointOfInterestService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<PointOfInterestResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PointOfInterest/PointOfInterest"])]
    public async Task<IActionResult> GetAsync(PointOfInterestRequest request)
    {
        var galaxies = await pointOfInterestService.GetPointOfInterestsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{poi:guid}")]
    [ProducesResponseType(typeof(MessageResponse<PointOfInterestResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PointOfInterest/PointOfInterest"])]
    public async Task<IActionResult> GetAsync(Guid pointOfInterestId)
    {
        var pointOfInterest = await pointOfInterestService.GetPointOfInterestByIdAsync(pointOfInterestId);
        return Ok(pointOfInterest);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<PointOfInterestResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["PointOfInterest/PointOfInterest"])]
    public async Task<IActionResult> PostAsync([FromBody] PointOfInterestRequest pointOfInterest)
    {
        var response = await pointOfInterestService.UpsertPointOfInterestAsync(pointOfInterest);
        return Ok(response);
    }

    [HttpDelete("{poi:guid}")]
    [SwaggerOperation(Tags = ["PointOfInterest/PointOfInterest"])]
    public async Task<IActionResult> DeleteAsync(Guid pointOfInterestId)
    {
        await pointOfInterestService.DeletePointOfInterestAsync(pointOfInterestId);
        return Ok();
    }
}