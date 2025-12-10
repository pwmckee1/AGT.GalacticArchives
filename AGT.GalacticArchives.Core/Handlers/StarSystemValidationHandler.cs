using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers;

public class StarSystemValidationHandler : BaseValidationHandler, IGoogleSheetValidationHandler
{
    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(StarSystemImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<StarSystemImport> starSystemDbRecords)
        {
            throw new InvalidCastException(string.Format(GoogleSheetResource.UnableToImportError, nameof(StarSystem)));
        }

        int lineNumber = BusinessRuleConstants.StartingImportSheetLineNumber;
        string? sheetName = GoogleSheetResource.StarSystemSheetName;

        foreach (var starSystemField in starSystemDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullableDateTimeStrategy(
                    starSystemField.DiscoveryDate,
                    lineNumber,
                    nameof(starSystemField.DiscoveryDate).GetDescription<StarSystemImport>(),
                    sheetName),
                new GalacticCoordinateStrategy(
                    starSystemField.GalacticCoordinates,
                    lineNumber,
                    nameof(starSystemField.GalacticCoordinates).GetDescription<StarSystemImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starSystemField.GalaxyName,
                    lineNumber,
                    nameof(starSystemField.GalaxyName).GetDescription<StarSystemImport>(),
                    sheetName),
                new HexadecimalGlyphStrategy(
                    starSystemField.GlyphCode,
                    lineNumber,
                    nameof(starSystemField.GlyphCode).GetDescription<StarSystemImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starSystemField.Name,
                    lineNumber,
                    nameof(starSystemField.Name).GetDescription<StarSystemImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starSystemField.RegionName,
                    lineNumber,
                    nameof(starSystemField.GalaxyName).GetDescription<StarSystemImport>(),
                    sheetName),
                new NullFieldStrategy(
                    starSystemField.StarSystemNameAllPlatforms,
                    lineNumber,
                    nameof(starSystemField.StarSystemNameAllPlatforms).GetDescription<StarSystemImport>(),
                    sheetName),
                new HexadecimalDigitStrategy(
                    starSystemField.SystemHexadecimal,
                    lineNumber,
                    nameof(starSystemField.SystemHexadecimal).GetDescription<StarSystemImport>(),
                    sheetName),
            };

            ValidateStrategies(strategies, errors);
            lineNumber++;
        }

        return errors;
    }
}