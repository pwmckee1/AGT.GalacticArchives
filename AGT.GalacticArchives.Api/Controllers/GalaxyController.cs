using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Interfaces.GameData;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("galaxy")]
public class GalaxyController(IGalaxyService galaxyService): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var galaxies = await galaxyService.GetGalaxiesAsync();
        return Ok(galaxies);
    }

    [HttpGet("{galaxyId}")]
    public async Task<IActionResult> GetAsync(Guid galaxyId)
    {
        var galaxy = await galaxyService.GetGalaxyByIdAsync(galaxyId);
        return Ok(galaxy);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Galaxy galaxy)
    {
        var response = await galaxyService.UpsertGalaxyAsync(galaxy);
        return Ok(response);
    }

    [HttpDelete("{galaxyId}")]
    public async Task<IActionResult> DeleteAsync(Guid galaxyId)
    {
        await galaxyService.DeleteGalaxyAsync(galaxyId);
        return Ok();
    }
}