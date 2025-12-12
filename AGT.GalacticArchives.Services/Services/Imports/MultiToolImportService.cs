using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class MultiToolImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<MultiToolImport>> importManagers)
    : ImportService<MultiToolImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<MultiToolImport> _importManager =
        importManagers[NamedKeys.Managers.MultiToolManager];

    protected override string SheetName => ImportResource.MultiToolSheetName;

    protected override Type CsvMapType => typeof(MultiToolCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<MultiToolImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}