using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class PlanetImportValidationHandler : BaseImportValidationHandler, IGoogleSheetValidationHandler
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
                    planetField.DiscoveryPlatform?.ToString(),
                    LineNumber,
                    nameof(planetField.DiscoveryPlatform).GetDescription<PlanetImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GameModeTypes>(
                    planetField.GameModeType?.ToString(),
                    LineNumber,
                    nameof(planetField.GameModeType).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.GameReleaseName,
                    LineNumber,
                    nameof(planetField.GameReleaseName).GetDescription<PlanetImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GalaxyTypes>(
                    planetField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(planetField.Galaxy).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.Region,
                    LineNumber,
                    nameof(planetField.Region).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.StarSystem,
                    LineNumber,
                    nameof(planetField.StarSystem).GetDescription<PlanetImport>(),
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
                    planetField.DiscovererGamertag,
                    LineNumber,
                    nameof(planetField.DiscovererGamertag).GetDescription<PlanetImport>(),
                    SheetName),
                new NullFieldStrategy(
                    planetField.SurveyorGamertag,
                    LineNumber,
                    nameof(planetField.SurveyorGamertag).GetDescription<PlanetImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}