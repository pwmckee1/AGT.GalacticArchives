using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class SettlementImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<SettlementImport>> importManagers)
    : ImportService<SettlementImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<SettlementImport> _importManager =
        importManagers[NamedKeys.Managers.SettlementManager];

    protected override string SheetName => ImportResource.SettlementSheetName;

    protected override Type CsvMapType => typeof(SettlementCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<SettlementImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}