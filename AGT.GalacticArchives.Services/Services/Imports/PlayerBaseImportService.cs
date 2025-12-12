using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Managers.Imports;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using Autofac.Features.Indexed;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PlayerBaseImportService(
    IEnumerable<IImportValidationHandler> importValidationHandlers,
    IIndex<string, IImportFormFileManager<PlayerBaseImport>> importManagers)
    : ImportService<PlayerBaseImport>(importValidationHandlers)
{
    private readonly IImportFormFileManager<PlayerBaseImport> _importManager =
        importManagers[NamedKeys.Managers.PlayerBaseManager];

    protected override string SheetName => ImportResource.PlayerBaseSheetName;

    protected override Type CsvMapType => typeof(PlayerBaseCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<PlayerBaseImport> importData)
    {
        await _importManager.ImportSheetDataAsync(importData);
    }
}