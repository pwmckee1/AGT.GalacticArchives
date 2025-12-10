using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class PlanetImportManager : IGoogleSheetImportManager<PlanetImport>
{
    public async Task ImportSheetDataAsync(HashSet<PlanetImport> importData)
    {
        await Task.Run(() => { });
    }
}