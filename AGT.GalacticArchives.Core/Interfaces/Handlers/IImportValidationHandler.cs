namespace AGT.GalacticArchives.Core.Interfaces.Handlers;

public interface IImportValidationHandler
{
    bool CanHandle<T>();

    HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors);
}