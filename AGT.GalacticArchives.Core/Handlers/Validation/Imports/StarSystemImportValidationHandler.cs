using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class StarSystemImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.StarSystemSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(StarSystemImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<StarSystemImport> starSystemDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(StarSystem)));
        }

        foreach (var starSystemField in starSystemDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    starSystemField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(starSystemField.Galaxy).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starSystemField.RegionName,
                    LineNumber,
                    nameof(starSystemField.Galaxy).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starSystemField.StarSystemName,
                    LineNumber,
                    nameof(starSystemField.StarSystemName).GetDescription<StarSystemImport>(),
                    SheetName),
                new GalacticCoordinateStrategy(
                    starSystemField.GalacticCoordinates,
                    LineNumber,
                    nameof(starSystemField.GalacticCoordinates).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullableDateTimeStrategy(
                    starSystemField.SurveyDate?.ToString(),
                    LineNumber,
                    nameof(starSystemField.SurveyDate).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starSystemField.DiscoveredBy,
                    LineNumber,
                    nameof(starSystemField.DiscoveredBy).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullableBoolFieldStrategy(
                    starSystemField.IsGiantSystem?.ToString(),
                    LineNumber,
                    nameof(starSystemField.IsGiantSystem).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starSystemField.GameRelease,
                    LineNumber,
                    nameof(starSystemField.GameRelease).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    starSystemField.NumberOfPlanets?.ToString(),
                    LineNumber,
                    nameof(starSystemField.NumberOfPlanets).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    starSystemField.NumberOfMoons?.ToString(),
                    LineNumber,
                    nameof(starSystemField.NumberOfMoons).GetDescription<StarSystemImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starSystemField.SurveyedBy,
                    LineNumber,
                    nameof(starSystemField.SurveyedBy).GetDescription<StarSystemImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}