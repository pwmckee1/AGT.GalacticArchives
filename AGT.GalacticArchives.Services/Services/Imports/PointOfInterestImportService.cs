using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PointOfInterestImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<PointOfInterestImport>> importManagers)
    : ImportService<PointOfInterestImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<PointOfInterestImport> _importManager =
        importManagers[NamedKeys.Managers.PointOfInterestManager];

    protected override string SheetName => ImportResource.PointOfInterestSheetName;

    protected override Type CsvMapType => typeof(PointOfInterestCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<PointOfInterestImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}