using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class FaunaImportManager : IGoogleSheetImportManager<FaunaImport>
{
    public async Task ImportSheetDataAsync(HashSet<FaunaImport> importData)
    {
        await Task.Run(() => { });
    }
}