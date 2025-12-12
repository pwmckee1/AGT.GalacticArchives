using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PointOfInterestImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<PointOfInterestImport>> importManagers)
    : GoogleSheetImportService<PointOfInterestImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<PointOfInterestImport> _importManager =
        importManagers[NamedKeys.Managers.PointOfInterestManager];

    protected override string SheetName => ImportResource.PointOfInterestSheetName;

    protected override Type CsvMapType => typeof(PointOfInterestCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<PointOfInterestImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}