using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers;

public class StarshipValidationHandler : BaseValidationHandler, IGoogleSheetValidationHandler
{
    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(StarshipImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<StarshipImport> starshipDbRecords)
        {
            throw new InvalidCastException(string.Format(GoogleSheetResource.UnableToImportError, nameof(Starship)));
        }

        int lineNumber = BusinessRuleConstants.StartingImportSheetLineNumber;
        string? sheetName = GoogleSheetResource.StarshipSheetName;

        foreach (var starshipField in starshipDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new GalacticCoordinateStrategy(
                    starshipField.GalacticCoordinates,
                    lineNumber,
                    nameof(starshipField.GalacticCoordinates).GetDescription<StarshipImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starshipField.Galaxy,
                    lineNumber,
                    nameof(starshipField.Galaxy).GetDescription<StarshipImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starshipField.Name,
                    lineNumber,
                    nameof(starshipField.Name).GetDescription<StarshipImport>(),
                    sheetName),
                new HexadecimalGlyphStrategy(
                    starshipField.PortalGlyphs,
                    lineNumber,
                    nameof(starshipField.PortalGlyphs).GetDescription<StarshipImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starshipField.Region,
                    lineNumber,
                    nameof(starshipField.Region).GetDescription<StarshipImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starshipField.System,
                    lineNumber,
                    nameof(starshipField.System).GetDescription<StarshipImport>(),
                    sheetName),
                new NullableDateTimeStrategy(
                    starshipField.DiscoveredDate,
                    lineNumber,
                    nameof(starshipField.DiscoveredDate).GetDescription<StarshipImport>(),
                    sheetName),
            };

            ValidateStrategies(strategies, errors);
            lineNumber++;
        }

        return errors;
    }
}