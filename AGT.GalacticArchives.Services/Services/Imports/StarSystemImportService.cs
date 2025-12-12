using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarSystemImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<StarSystemImport>> importManagers)
    : ImportService<StarSystemImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<StarSystemImport> _importManager =
        importManagers[NamedKeys.Managers.StarSystemManager];

    protected override string SheetName => ImportResource.StarSystemSheetName;

    protected override Type CsvMapType => typeof(StarSystemCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<StarSystemImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}