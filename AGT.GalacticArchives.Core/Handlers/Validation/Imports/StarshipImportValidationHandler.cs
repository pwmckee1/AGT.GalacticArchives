using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class StarshipImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.StarshipSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(StarshipImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<StarshipImport> starshipDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(Starship)));
        }

        foreach (var starshipField in starshipDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    starshipField.DiscoveredBy,
                    LineNumber,
                    nameof(starshipField.DiscoveredBy).GetDescription<StarshipImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GamePlatformTypes>(
                    starshipField.GamePlatform?.ToString(),
                    LineNumber,
                    nameof(starshipField.GamePlatform).GetDescription<StarshipImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GameModeTypes>(
                    starshipField.GameMode?.ToString(),
                    LineNumber,
                    nameof(starshipField.GameMode).GetDescription<StarshipImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starshipField.Release,
                    LineNumber,
                    nameof(starshipField.Release).GetDescription<StarshipImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<GalaxyTypes>(
                    starshipField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(starshipField.Galaxy).GetDescription<StarshipImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starshipField.Region,
                    LineNumber,
                    nameof(starshipField.Region).GetDescription<StarshipImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starshipField.StarSystem,
                    LineNumber,
                    nameof(starshipField.StarSystem).GetDescription<StarshipImport>(),
                    SheetName),
                new GalacticCoordinateStrategy(
                    starshipField.GalacticCoordinates,
                    LineNumber,
                    nameof(starshipField.GalacticCoordinates).GetDescription<StarshipImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<StarshipLocationTypes>(
                    starshipField.Location?.ToString(),
                    LineNumber,
                    nameof(starshipField.Location).GetDescription<StarshipImport>(),
                    SheetName),
                new NullFieldStrategy(
                    starshipField.StarshipName,
                    LineNumber,
                    nameof(starshipField.StarshipName).GetDescription<StarshipImport>(),
                    SheetName),
                new EnumFieldTypeStrategy<ItemClassTypes>(
                    starshipField.Class?.ToString(),
                    LineNumber,
                    nameof(starshipField.Class).GetDescription<StarshipImport>(),
                    SheetName),
                new NullableDateTimeStrategy(
                    starshipField.DiscoveredDate?.ToString(),
                    LineNumber,
                    nameof(starshipField.DiscoveredDate).GetDescription<StarshipImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}