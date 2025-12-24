using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class PlanetImportService(
    IMapper mapper,
    IPlanetManager planetManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<PlanetImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    protected override Type CsvMapType => typeof(PlanetCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<PlanetImport> importData,
        CancellationToken ct = default)
    {
        var planets = mapper.Map<HashSet<Planet>>(importData);
        await planetManager.UpsertPlanetAsync(planets, ct);
    }
}