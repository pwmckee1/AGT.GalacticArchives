using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class SettlementImportService(
    IMapper mapper,
    ISettlementManager settlementManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<SettlementImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.SettlementSheetName;

    protected override Type CsvMapType => typeof(SettlementCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<SettlementImport> importData,
        CancellationToken ct = default)
    {
        var settlements = mapper.Map<HashSet<Settlement>>(importData);
        await settlementManager.UpsertSettlementAsync(settlements, ct);
    }
}