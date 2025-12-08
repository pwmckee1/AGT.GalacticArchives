namespace AGT.GalacticArchives.Core.Managers.Imports;

public interface IGoogleSheetImportManager<T>
{
    Task ImportSheetDataAsync(HashSet<T> importData);
}