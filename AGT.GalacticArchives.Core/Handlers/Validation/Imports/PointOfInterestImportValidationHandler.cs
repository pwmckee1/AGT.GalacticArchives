using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class PointOfInterestImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(PointOfInterestImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<PointOfInterestImport> pointOfInterestDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(PointOfInterest)));
        }

        foreach (var pointOfInterestField in pointOfInterestDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    pointOfInterestField.LocationType?.ToString(),
                    LineNumber,
                    nameof(pointOfInterestField.LocationType).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullFieldStrategy(
                    pointOfInterestField.PlanetName,
                    LineNumber,
                    nameof(pointOfInterestField.PlanetName).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullFieldStrategy(
                    pointOfInterestField.StarSystemName,
                    LineNumber,
                    nameof(pointOfInterestField.StarSystemName).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullFieldStrategy(
                    pointOfInterestField.RegionName,
                    LineNumber,
                    nameof(pointOfInterestField.RegionName).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullFieldStrategy(
                    pointOfInterestField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(pointOfInterestField.Galaxy).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullFieldStrategy(
                    pointOfInterestField.Surveyor,
                    LineNumber,
                    nameof(pointOfInterestField.Surveyor).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    pointOfInterestField.YYFirstCoordinate?.ToString(),
                    LineNumber,
                    nameof(pointOfInterestField.YYFirstCoordinate).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    pointOfInterestField.XXSecondCoordinate?.ToString(),
                    LineNumber,
                    nameof(pointOfInterestField.XXSecondCoordinate).GetDescription<PointOfInterestImport>(),
                    SheetName),
                new NullableDateTimeStrategy(
                    pointOfInterestField.DateOfSurvey?.ToString(),
                    LineNumber,
                    nameof(pointOfInterestField.DateOfSurvey).GetDescription<PointOfInterestImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}