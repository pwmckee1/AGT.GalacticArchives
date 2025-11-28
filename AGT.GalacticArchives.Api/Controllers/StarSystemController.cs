using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("star-system")]
public class StarSystemController(IStarSystemService starSystemService): ControllerBase
{

    [HttpGet("{starSystemId}")]
    public async Task<IActionResult> GetAsync(Guid starSystemId)
    {
        var starSystem = await starSystemService.GetStarSystemByIdAsync(starSystemId);
        return Ok(starSystem);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] StarSystem starSystem)
    {
        var response = await starSystemService.UpsertStarSystemAsync(starSystem);
        return Ok(response);
    }

    [HttpDelete("{starSystemId}")]
    public async Task<IActionResult> DeleteAsync(Guid starSystemId)
    {
        await starSystemService.DeleteStarSystemAsync(starSystemId);
        return Ok();
    }
}