using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarshipImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<StarshipImport>> importManagers)
    : GoogleSheetImportService<StarshipImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<StarshipImport> _importManager =
        importManagers[NamedKeys.Managers.StarshipManager];

    protected override string SheetName => GoogleSheetResource.StarshipSheetName;

    protected override Type CsvMapType => typeof(StarshipCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<StarshipImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}