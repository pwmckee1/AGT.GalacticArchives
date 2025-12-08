using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class PlayerBaseImportManager : IGoogleSheetImportManager<PlayerBaseImport>
{
    public async Task ImportSheetDataAsync(HashSet<PlayerBaseImport> importData)
    {
        await Task.Run(() => { });
    }
}