namespace AGT.GalacticArchives.Core.Handlers;

public interface IGoogleSheetValidationHandler
{
    bool CanHandle<T>();

    HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors);
}