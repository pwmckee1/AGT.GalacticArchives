using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Environments;
using AGT.GalacticArchives.Core.Models.Imports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers;

public class RegionValidationValidationHandler : BaseValidationHandler, IGoogleSheetValidationHandler
{
    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(RegionImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<RegionImport> regionDbRecords)
        {
            throw new InvalidCastException(string.Format(GoogleSheetResource.UnableToImportError, nameof(Region)));
        }

        int lineNumber = BusinessRuleConstants.StartingImportSheetLineNumber;
        string? sheetName = GoogleSheetResource.RegionSheetName;

        foreach (var regionField in regionDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    regionField.Name,
                    lineNumber,
                    nameof(regionField.Name).GetDescription<RegionImport>(),
                    sheetName),
                new NullFieldStrategy(
                    regionField.GalaxyName,
                    lineNumber,
                    nameof(regionField.GalaxyName).GetDescription<RegionImport>(),
                    sheetName),
                new GalacticCoordinateStrategy(
                    regionField.Coordinates,
                    lineNumber,
                    nameof(regionField.Coordinates).GetDescription<RegionImport>(),
                    sheetName),
                new GalacticQuadrantStrategy(
                    regionField.Quadrant,
                    lineNumber,
                    nameof(regionField.Quadrant).GetDescription<RegionImport>(),
                    sheetName),
                new HexadecimalDigitStrategy(
                    regionField.XX,
                    lineNumber,
                    nameof(regionField.XX).GetDescription<RegionImport>(),
                    sheetName),
                new HexadecimalDigitStrategy(
                    regionField.YYAltitude,
                    lineNumber,
                    nameof(regionField.YYAltitude).GetDescription<RegionImport>(),
                    sheetName),
                new HexadecimalDigitStrategy(
                    regionField.ZZ,
                    lineNumber,
                    nameof(regionField.ZZ).GetDescription<RegionImport>(),
                    sheetName),
                new NullableIntFieldStrategy(
                    regionField.DocSequence,
                    lineNumber,
                    nameof(regionField.DocSequence).GetDescription<RegionImport>(),
                    sheetName),
                new NullFieldStrategy(
                    regionField.GameRelease,
                    lineNumber,
                    nameof(regionField.GameRelease).GetDescription<RegionImport>(),
                    sheetName),
                new NullFieldStrategy(
                    regionField.AutoSurveyDate,
                    lineNumber,
                    nameof(regionField.AutoSurveyDate).GetDescription<RegionImport>(),
                    sheetName),
                new NullableIntFieldStrategy(
                    regionField.LightYearsFromCenter,
                    lineNumber,
                    nameof(regionField.LightYearsFromCenter).GetDescription<RegionImport>(),
                    sheetName),
                new NullableDateTimeStrategy(
                    regionField.EarliestSystemDiscovery,
                    lineNumber,
                    nameof(regionField.EarliestSystemDiscovery).GetDescription<RegionImport>(),
                    sheetName),
                new BaseCoordinateStrategy(
                    regionField.BaseCoordinates,
                    lineNumber,
                    nameof(regionField.BaseCoordinates).GetDescription<RegionImport>(),
                    sheetName),
                new IntegerFieldStrategy(
                    regionField.XXDec,
                    lineNumber,
                    nameof(regionField.XXDec).GetDescription<RegionImport>(),
                    sheetName),
                new IntegerFieldStrategy(
                    regionField.YYDec,
                    lineNumber,
                    nameof(regionField.YYDec).GetDescription<RegionImport>(),
                    sheetName),
                new IntegerFieldStrategy(
                    regionField.ZZDec,
                    lineNumber,
                    nameof(regionField.ZZDec).GetDescription<RegionImport>(),
                    sheetName),
                new HexadecimalGlyphStrategy(
                    regionField.Glyphs,
                    lineNumber,
                    nameof(regionField.Glyphs).GetDescription<RegionImport>(),
                    sheetName),
                new NullableFloatFieldStrategy(
                    regionField.Version,
                    lineNumber,
                    nameof(regionField.Version).GetDescription<RegionImport>(),
                    sheetName),
                new NullableIntFieldStrategy(
                    regionField.GalaxyId,
                    lineNumber,
                    nameof(regionField.GalaxyId).GetDescription<RegionImport>(),
                    sheetName),
            };

            ValidateStrategies(strategies, errors);
            lineNumber++;
        }

        return errors;
    }
}