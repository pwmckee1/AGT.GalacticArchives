using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class PlanetImportManager : IGoogleSheetImportManager<PlanetImport>
{
    public async Task ImportSheetDataAsync(HashSet<PlanetImport> importData)
    {
        await Task.Run(() => { });
    }
}