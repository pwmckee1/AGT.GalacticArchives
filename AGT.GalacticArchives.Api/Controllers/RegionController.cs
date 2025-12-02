using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("region")]
public class RegionController(IRegionService regionService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<RegionResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Region/Region"])]
    public async Task<IActionResult> GetAsync(RegionRequest request)
    {
        var galaxies = await regionService.GetRegionsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{regionId}")]
    [ProducesResponseType(typeof(MessageResponse<RegionResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Region/Region"])]
    public async Task<IActionResult> GetAsync(Guid regionId)
    {
        var region = await regionService.GetRegionByIdAsync(regionId);
        return Ok(region);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<RegionResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Region/Region"])]
    public async Task<IActionResult> PostAsync([FromBody] RegionRequest region)
    {
        var response = await regionService.UpsertRegionAsync(region);
        return Ok(response);
    }

    [HttpDelete("{regionId}")]
    [SwaggerOperation(Tags = ["Region/Region"])]
    public async Task<IActionResult> DeleteAsync(Guid regionId)
    {
        await regionService.DeleteRegionAsync(regionId);
        return Ok();
    }
}