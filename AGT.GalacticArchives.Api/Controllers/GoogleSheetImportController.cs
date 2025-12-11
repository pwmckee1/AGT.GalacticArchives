using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Application;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Services.Imports;
using Autofac.Features.Indexed;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AGT.GalacticArchives.Controllers;

public class GoogleSheetImportController(IIndex<string, IGoogleSheetImportService> googleSheetImportServices)
    : ControllerBase
{
    /// <summary>
    /// When using this to import data from the AGT GoogleSheet DB, select the worksheet to be imported in Google Sheets,
    /// go to File > Download > Comma Separated Values.
    /// The filename will look like "AGT Galactic Archives DB 2025-12-10 - Region DB". The filename
    /// will be parsed to see if it is a valid sheet by looking for one of the valid sheet name values in the filename.
    /// The <see cref="GoogleSheetTypes"/> enum descriptions will be used as matching criteria.
    /// </summary>
    /// <returns>
    /// Returns:
    /// - 200 OK if the import was successful
    /// - 400 Bad Request if the sheet type is invalid, with a message listing valid sheet types
    /// </returns>
    [HttpPost]
    [SwaggerOperation(Tags = ["GoogleSheetImport/GoogleSheetImport"])]
    public async Task<IActionResult> Post()
    {
        var googleSheetImportFile = HttpContext.Request.Form.Files.SingleOrDefault();
        if (googleSheetImportFile != null)
        {
            string[] spaceSeparatedFileName = googleSheetImportFile.Name.Split(' ');
            bool isValidSheet = false;
            foreach (string fileNamePart in spaceSeparatedFileName)
            {
                isValidSheet = Enum.TryParse(fileNamePart, out GoogleSheetTypes _);
            }

            if (isValidSheet)
            {
                Enum.TryParse(googleSheetImportFile.Name, out GoogleSheetTypes googleSheetType);
                var importService = googleSheetImportServices[googleSheetType.GetDescription()];
                await importService.ImportGoogleSheetDataAsync(googleSheetImportFile!);

                return Ok();
            }
        }

        return BadRequest(
            string.Format(
                GoogleSheetResource.InvalidSheetProvided,
                EnumExtensions.GetDescriptions<GoogleSheetTypes>()));
    }
}