using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class RegionImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<RegionImport>> importManagers)
    : GoogleSheetImportService<RegionImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<RegionImport> _importManager =
        importManagers[NamedKeys.Managers.RegionManager];

    protected override string SheetName => GoogleSheetResource.RegionSheetName;

    protected override Type CsvMapType => typeof(RegionCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<RegionImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}