using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Services.Imports;
using Autofac.Features.Indexed;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

public class GoogleSheetImportController(IIndex<string, IGoogleSheetImportService> googleSheetImportServices)
    : ControllerBase
{
    [HttpPost]
    [SwaggerOperation(Tags = ["GoogleSheetImport/GoogleSheetImport"])]
    public async Task<IActionResult> Post()
    {
        var googleSheetImportFile = HttpContext.Request.Form.Files.SingleOrDefault();
        bool isValidGoogleSheet = Enum.TryParse(googleSheetImportFile?.Name, out GoogleSheetTypes googleSheetType);

        if (googleSheetImportFile != null && isValidGoogleSheet)
        {
            var importService = googleSheetImportServices[googleSheetType.GetDescription()];
            await importService.ImportGoogleSheetDataAsync(googleSheetImportFile);

            return Ok();
        }

        return BadRequest(
            string.Format(
                GoogleSheetResource.InvalidSheetProvided,
                EnumExtensions.GetDescriptions<GoogleSheetTypes>()));
    }
}