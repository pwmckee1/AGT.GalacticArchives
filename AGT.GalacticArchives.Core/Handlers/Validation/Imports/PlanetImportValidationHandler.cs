using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class PlanetImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(PlanetImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<PlanetImport> records)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(Planet)));
        }

        foreach (var planetField in records)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    planetField.GamePlatformType?.ToString(),
                    LineNumber,
                    nameof(planetField.GamePlatformType).GetDescription<PlanetImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GameModeTypes>(
                    planetField.GameModeType?.ToString(),
                    LineNumber,
                    nameof(planetField.GameModeType).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.GameRelease,
                    LineNumber,
                    nameof(planetField.GameRelease).GetDescription<PlanetImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GalaxyTypes>(
                    planetField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(planetField.Galaxy).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.RegionName,
                    LineNumber,
                    nameof(planetField.RegionName).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.StarSystemName,
                    LineNumber,
                    nameof(planetField.StarSystemName).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.PlanetName,
                    LineNumber,
                    nameof(planetField.PlanetName).GetDescription<PlanetImport>(),
                    SheetName),
                new NullableBoolFieldStrategy(
                    planetField.IsPlanet?.ToString(),
                    LineNumber,
                    nameof(planetField.IsPlanet).GetDescription<PlanetImport>(),
                    SheetName),
                new NullableBoolFieldStrategy(
                    planetField.IsGasGiant?.ToString(),
                    LineNumber,
                    nameof(planetField.IsGasGiant).GetDescription<PlanetImport>(),
                    SheetName),
                new NullableBoolFieldStrategy(
                    planetField.HasRings?.ToString(),
                    LineNumber,
                    nameof(planetField.IsGasGiant).GetDescription<PlanetImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<BiomeTypes>(
                    planetField.PlanetBiomeType?.ToString(),
                    LineNumber,
                    nameof(planetField.PlanetBiomeType).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.DiscoveredBy,
                    LineNumber,
                    nameof(planetField.DiscoveredBy).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.SurveyedBy,
                    LineNumber,
                    nameof(planetField.SurveyedBy).GetDescription<PlanetImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}