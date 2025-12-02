using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

[ApiController]
[Route("settlement")]
public class SettlementController(ISettlementService settlementService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(MessageResponse<HashSet<SettlementResponse>>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Settlement/Settlement"])]
    public async Task<IActionResult> GetAsync(SettlementRequest request)
    {
        var galaxies = await settlementService.GetSettlementsAsync(request);
        return Ok(galaxies);
    }

    [HttpGet("{settlementId}")]
    [ProducesResponseType(typeof(MessageResponse<SettlementResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Settlement/Settlement"])]
    public async Task<IActionResult> GetAsync(Guid settlementId)
    {
        var settlement = await settlementService.GetSettlementByIdAsync(settlementId);
        return Ok(settlement);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResponse<SettlementResponse>), StatusCodes.Status200OK)]
    [SwaggerOperation(Tags = ["Settlement/Settlement"])]
    public async Task<IActionResult> PostAsync([FromBody] SettlementRequest settlement)
    {
        var response = await settlementService.UpsertSettlementAsync(settlement);
        return Ok(response);
    }

    [HttpDelete("{settlementId}")]
    [SwaggerOperation(Tags = ["Settlement/Settlement"])]
    public async Task<IActionResult> DeleteAsync(Guid settlementId)
    {
        await settlementService.DeleteSettlementAsync(settlementId);
        return Ok();
    }
}