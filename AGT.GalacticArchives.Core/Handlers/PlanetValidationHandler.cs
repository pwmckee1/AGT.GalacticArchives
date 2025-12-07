using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers;

public class PlanetValidationHandler : BaseValidationHandler, IGoogleSheetValidationHandler
{
    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(PlanetImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<PlanetImport> records)
        {
            throw new InvalidCastException(string.Format(GoogleSheetResource.UnableToImportError, nameof(Planet)));
        }

        int lineNumber = BusinessRuleConstants.StartingImportSheetLineNumber;
        string? sheetName = GoogleSheetResource.PlanetSheetName;

        foreach (var planetField in records)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    planetField.Galaxy,
                    lineNumber,
                    nameof(planetField.Galaxy).GetDescription<PlanetImport>(),
                    sheetName),
                new NullFieldStrategy(
                    planetField.Region,
                    lineNumber,
                    nameof(planetField.Region).GetDescription<PlanetImport>(),
                    sheetName),
                new NullFieldStrategy(
                    planetField.System,
                    lineNumber,
                    nameof(planetField.System).GetDescription<PlanetImport>(),
                    sheetName),
                new NullFieldStrategy(
                    planetField.Name,
                    lineNumber,
                    nameof(planetField.Name).GetDescription<PlanetImport>(),
                    sheetName),
                new HexadecimalGlyphStrategy(
                    planetField.PlanetGlyphs,
                    lineNumber,
                    nameof(planetField.PlanetGlyphs).GetDescription<PlanetImport>(),
                    sheetName),
            };

            ValidateStrategies(strategies, errors);
            lineNumber++;
        }

        return errors;
    }
}