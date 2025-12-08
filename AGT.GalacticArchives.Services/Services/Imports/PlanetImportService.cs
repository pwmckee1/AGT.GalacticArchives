using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PlanetImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<PlanetImport>> importManagers)
    : GoogleSheetImportService<PlanetImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<PlanetImport> _importManager =
        importManagers[NamedKeys.Managers.PlanetManager];

    protected override string SheetName => GoogleSheetResource.PlanetSheetName;

    protected override Type CsvMapType => typeof(PlanetCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<PlanetImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}