using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarSystemImportService(
    IEnumerable<IGoogleSheetValidationHandler> googleSheetValidationHandlers,
    IIndex<string, IGoogleSheetImportManager<StarSystemImport>> importManagers)
    : GoogleSheetImportService<StarSystemImport>(googleSheetValidationHandlers)
{
    private readonly IGoogleSheetImportManager<StarSystemImport> _importManager =
        importManagers[NamedKeys.Managers.StarSystemManager];

    protected override string SheetName => GoogleSheetResource.StarSystemSheetName;

    protected override Type CsvMapType => typeof(StarSystemCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<StarSystemImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}