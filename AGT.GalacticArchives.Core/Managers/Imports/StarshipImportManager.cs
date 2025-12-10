using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class StarshipImportManager : IGoogleSheetImportManager<StarshipImport>
{
    public async Task ImportSheetDataAsync(HashSet<StarshipImport> importData)
    {
        await Task.Run(() => { });
    }
}