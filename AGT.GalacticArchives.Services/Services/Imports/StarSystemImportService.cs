using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarSystemImportService(
    IMapper mapper,
    IStarSystemManager starSystemManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<StarSystemImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.StarSystemSheetName;

    protected override Type CsvMapType => typeof(StarSystemCsvMap);

    protected override async Task ProcessValidatedDataAsync(
        HashSet<StarSystemImport> importData,
        CancellationToken ct = default)
    {
        var starSystems = mapper.Map<HashSet<StarSystem>>(importData);
        await starSystemManager.UpsertStarSystemAsync(starSystems, ct);
    }
}