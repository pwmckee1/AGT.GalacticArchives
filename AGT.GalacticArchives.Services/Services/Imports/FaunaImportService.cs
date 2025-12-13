using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class FaunaImportService(
    IMapper mapper,
    IFaunaManager faunaManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<FaunaImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.FaunaSheetName;

    protected override Type CsvMapType => typeof(FaunaCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<FaunaImport> importData)
    {
        var fauna = mapper.Map<HashSet<Fauna>>(importData);
        await faunaManager.UpsertFaunaAsync(fauna);
    }
}