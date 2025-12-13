using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("cache")]
public class CacheController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}