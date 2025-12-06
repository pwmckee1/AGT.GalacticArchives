using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class SettlementImportManager : IGoogleSheetImportManager<SettlementImport>
{
    public async Task ImportSheetDataAsync(HashSet<SettlementImport> importData)
    {
        await Task.Run(() => { });
    }
}