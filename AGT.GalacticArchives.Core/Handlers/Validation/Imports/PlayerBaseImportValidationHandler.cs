using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class PlayerBaseImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(PlayerBaseImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<PlayerBaseImport> playerBaseDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(PlayerBase)));
        }

        foreach (var playerBaseField in playerBaseDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    playerBaseField.PlayerBaseName,
                    LineNumber,
                    nameof(playerBaseField.PlayerBaseName).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullFieldStrategy(
                    playerBaseField.PlanetName,
                    LineNumber,
                    nameof(playerBaseField.PlanetName).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullFieldStrategy(
                    playerBaseField.StarSystemName,
                    LineNumber,
                    nameof(playerBaseField.StarSystemName).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullFieldStrategy(
                    playerBaseField.RegionName,
                    LineNumber,
                    nameof(playerBaseField.RegionName).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullFieldStrategy(
                    playerBaseField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(playerBaseField.Galaxy).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullFieldStrategy(
                    playerBaseField.Surveyor,
                    LineNumber,
                    nameof(playerBaseField.Surveyor).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    playerBaseField.YYFirstCoordinate?.ToString(),
                    LineNumber,
                    nameof(playerBaseField.YYFirstCoordinate).GetDescription<PlayerBaseImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    playerBaseField.XXSecondCoordinate?.ToString(),
                    LineNumber,
                    nameof(playerBaseField.XXSecondCoordinate).GetDescription<PlayerBaseImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}