using AGT.GalacticArchives.Services.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("cache")]
public class CacheController(ICacheService cacheService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(cacheService.GetCacheKeys());
    }

    [HttpPost("{cacheKey}")]
    public async Task<IActionResult> PostAsync(string? cacheKey = null)
    {
        await cacheService.ClearCacheByKey(cacheKey);
        return Ok();
    }
}