using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarshipImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<StarshipImport>> importManagers)
    : ImportService<StarshipImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<StarshipImport> _importManager =
        importManagers[NamedKeys.Managers.StarshipManager];

    protected override string SheetName => ImportResource.StarshipSheetName;

    protected override Type CsvMapType => typeof(StarshipCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<StarshipImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}