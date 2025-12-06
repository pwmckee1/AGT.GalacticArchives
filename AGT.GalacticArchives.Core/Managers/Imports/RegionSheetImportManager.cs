using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class RegionSheetImportManager : IGoogleSheetImportManager<RegionImport>
{
    public async Task ImportSheetDataAsync(HashSet<RegionImport> importData)
    {
        await Task.Run(() => { });
    }
}