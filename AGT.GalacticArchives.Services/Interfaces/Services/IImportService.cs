using Microsoft.AspNetCore.Http;

namespace AGT.GalacticArchives.Services.Interfaces.Services;

public interface IImportService
{
    Task ImportFormFileAsync(IFormFile form);
}