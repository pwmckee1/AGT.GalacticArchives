using Microsoft.AspNetCore.Http;

namespace AGT.GalacticArchives.Services.Services.Imports;

public interface IGoogleSheetImportService
{
    Task ImportGoogleSheetDataAsync(IFormFile form);
}