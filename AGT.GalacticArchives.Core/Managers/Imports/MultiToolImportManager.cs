using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class MultiToolImportManager : IGoogleSheetImportManager<MultiToolImport>
{
    public async Task ImportSheetDataAsync(HashSet<MultiToolImport> importData)
    {
        await Task.Run(() => { });
    }
}