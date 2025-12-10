using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class RegionSheetImportManager : IGoogleSheetImportManager<RegionImport>
{
    public async Task ImportSheetDataAsync(HashSet<RegionImport> importData)
    {
        await Task.Run(() => { });
    }
}