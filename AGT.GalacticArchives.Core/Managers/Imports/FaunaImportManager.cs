using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class FaunaImportManager : IGoogleSheetImportManager<FaunaImport>
{
    public async Task ImportSheetDataAsync(HashSet<FaunaImport> importData)
    {
        await Task.Run(() => { });
    }
}