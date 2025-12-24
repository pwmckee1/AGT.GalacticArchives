using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class FaunaImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(FaunaImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<FaunaImport> faunaDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(Fauna)));
        }

        foreach (var faunaField in faunaDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    faunaField.FaunaName,
                    LineNumber,
                    nameof(faunaField.FaunaName).GetDescription<FaunaImport>(),
                    SheetName),
                new NullFieldStrategy(
                    faunaField.StarSystemName,
                    LineNumber,
                    nameof(faunaField.StarSystemName).GetDescription<FaunaImport>(),
                    SheetName),
                new NullFieldStrategy(
                    faunaField.RegionName,
                    LineNumber,
                    nameof(faunaField.RegionName).GetDescription<FaunaImport>(),
                    SheetName),
                new NullFieldStrategy(
                    faunaField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(faunaField.Galaxy).GetDescription<FaunaImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}