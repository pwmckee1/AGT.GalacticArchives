using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PointOfInterestImportService(
    IMapper mapper,
    IPointOfInterestManager pointOfInterestManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<PointOfInterestImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.PointOfInterestSheetName;

    protected override Type CsvMapType => typeof(PointOfInterestCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<PointOfInterestImport> importData,
        CancellationToken ct = default)
    {
        var pointOfInterests = mapper.Map<HashSet<PointOfInterest>>(importData);
        await pointOfInterestManager.UpsertPointOfInterestAsync(pointOfInterests, ct);
    }
}