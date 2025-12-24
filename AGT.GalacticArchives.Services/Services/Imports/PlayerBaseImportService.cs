using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PlayerBaseImportService(
    IMapper mapper,
    IPlayerBaseManager playerBaseManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<PlayerBaseImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.PlayerBaseSheetName;

    protected override Type CsvMapType => typeof(PlayerBaseCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<PlayerBaseImport> importData,
        CancellationToken ct = default)
    {
        var playerBases = mapper.Map<HashSet<PlayerBase>>(importData);
        await playerBaseManager.UpsertPlayerBaseAsync(playerBases, ct);
    }
}