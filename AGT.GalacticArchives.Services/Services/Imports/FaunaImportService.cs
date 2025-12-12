using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class FaunaImportService(
    IEnumerable<IImportValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<FaunaImport>> importManagers)
    : GoogleSheetImportService<FaunaImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<FaunaImport> _importManager =
        importManagers[NamedKeys.Managers.FaunaManager];

    protected override string SheetName => ImportResource.FaunaSheetName;

    protected override Type CsvMapType => typeof(FaunaCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<FaunaImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}