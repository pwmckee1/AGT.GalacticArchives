using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class MultiToolImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(MultiToolImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<MultiToolImport> multiToolDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(MultiTool)));
        }

        foreach (var multiToolField in multiToolDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    multiToolField.MultiToolName,
                    LineNumber,
                    nameof(multiToolField.MultiToolName).GetDescription<MultiToolImport>(),
                    SheetName),
                new NullFieldStrategy(
                    multiToolField.StarSystemName,
                    LineNumber,
                    nameof(multiToolField.StarSystemName).GetDescription<MultiToolImport>(),
                    SheetName),
                new NullFieldStrategy(
                    multiToolField.RegionName,
                    LineNumber,
                    nameof(multiToolField.RegionName).GetDescription<MultiToolImport>(),
                    SheetName),
                new NullFieldStrategy(
                    multiToolField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(multiToolField.Galaxy).GetDescription<MultiToolImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    multiToolField.YAxisPlanetCoordinate?.ToString(),
                    LineNumber,
                    nameof(multiToolField.YAxisPlanetCoordinate).GetDescription<MultiToolImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    multiToolField.XAxisPlanetCoordinate?.ToString(),
                    LineNumber,
                    nameof(multiToolField.XAxisPlanetCoordinate).GetDescription<MultiToolImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}