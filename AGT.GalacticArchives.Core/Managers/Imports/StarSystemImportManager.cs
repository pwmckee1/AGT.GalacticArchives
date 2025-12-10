using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class StarSystemImportManager : IGoogleSheetImportManager<StarSystemImport>
{
    public async Task ImportSheetDataAsync(HashSet<StarSystemImport> importData)
    {
        await Task.Run(() => { });
    }
}