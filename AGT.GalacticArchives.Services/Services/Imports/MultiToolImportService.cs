using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class MultiToolImportService(
    IMapper mapper,
    IMultiToolManager multiToolManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<MultiToolImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.MultiToolSheetName;

    protected override Type CsvMapType => typeof(MultiToolCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<MultiToolImport> importData)
    {
        var multiTools = mapper.Map<HashSet<MultiTool>>(importData);
        await multiToolManager.UpsertMultiToolAsync(multiTools);
    }
}