using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class SettlementImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<SettlementImport>> importManagers)
    : GoogleSheetImportService<SettlementImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<SettlementImport> _importManager =
        importManagers[NamedKeys.Managers.SettlementManager];

    protected override string SheetName => GoogleSheetResource.SettlementSheetName;

    protected override Type CsvMapType => typeof(SettlementCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<SettlementImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}