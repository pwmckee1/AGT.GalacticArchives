using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Managers.Imports;

public class PointOfInterestImportManager : IGoogleSheetImportManager<PointOfInterestImport>
{
    public async Task ImportSheetDataAsync(HashSet<PointOfInterestImport> importData)
    {
        await Task.Run(() => { });
    }
}