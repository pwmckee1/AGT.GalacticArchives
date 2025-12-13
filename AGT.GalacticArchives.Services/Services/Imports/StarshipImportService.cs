using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Mapping.CsvMaps;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Globalization;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Services.Imports;

public class StarshipImportService(
    IMapper mapper,
    IStarshipManager starshipManager,
    IEnumerable<IImportValidationHandler> importValidationHandlers)
    : ImportService<StarshipImport>(importValidationHandlers)
{
    protected override string SheetName => ImportResource.StarshipSheetName;

    protected override Type CsvMapType => typeof(StarshipCsvMap);

    protected override async Task ProcessValidatedDataAsync(HashSet<StarshipImport> importData)
    {
        var starships = mapper.Map<HashSet<Starship>>(importData);
        await starshipManager.UpsertStarshipAsync(starships);
    }
}