namespace AGT.GalacticArchives.Core.Interfaces.Handlers;

public interface IGoogleSheetValidationHandler
{
    bool CanHandle<T>();

    HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors);
}