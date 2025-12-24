using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class RegionImportService(
    IMapper mapper,
    IRegionManager regionManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<RegionImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.RegionSheetName;

    protected override Type CsvMapType => typeof(RegionCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<RegionImport> importData,
        CancellationToken ct = default)
    {
        var regions = mapper.Map<HashSet<Region>>(importData);
        await regionManager.UpsertRegionAsync(regions, ct);
    }
}