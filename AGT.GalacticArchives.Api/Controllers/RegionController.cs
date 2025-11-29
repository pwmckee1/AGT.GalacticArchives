using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("region")]
public class RegionController(IRegionService regionService): ControllerBase
{

    [HttpGet("{regionId}")]
    public async Task<IActionResult> GetAsync(Guid regionId)
    {
        var region = await regionService.GetRegionByIdAsync(regionId);
        return Ok(region);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Region region)
    {
        var response = await regionService.UpsertRegionAsync(region);
        return Ok(response);
    }

    [HttpDelete("{regionId}")]
    public async Task<IActionResult> DeleteAsync(Guid regionId)
    {
        await regionService.DeleteRegionAsync(regionId);
        return Ok();
    }
}