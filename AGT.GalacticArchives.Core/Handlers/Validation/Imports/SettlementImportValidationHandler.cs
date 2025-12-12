using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Models.InGame.Entities;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class SettlementImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.PlanetSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(SettlementImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<SettlementImport> settlementDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(Settlement)));
        }

        foreach (var settlementField in settlementDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new NullFieldStrategy(
                    settlementField.SettlementName,
                    LineNumber,
                    nameof(settlementField.SettlementName).GetDescription<SettlementImport>(),
                    SheetName),
                new NullFieldStrategy(
                    settlementField.PlanetName,
                    LineNumber,
                    nameof(settlementField.PlanetName).GetDescription<SettlementImport>(),
                    SheetName),
                new NullFieldStrategy(
                    settlementField.StarSystemName,
                    LineNumber,
                    nameof(settlementField.StarSystemName).GetDescription<SettlementImport>(),
                    SheetName),
                new NullFieldStrategy(
                    settlementField.Surveyor,
                    LineNumber,
                    nameof(settlementField.Surveyor).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    settlementField.YYFirstCoordinate?.ToString(),
                    LineNumber,
                    nameof(settlementField.YYFirstCoordinate).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableFloatFieldStrategy(
                    settlementField.XXSecondCoordinate?.ToString(),
                    LineNumber,
                    nameof(settlementField.XXSecondCoordinate).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableDateTimeStrategy(
                    settlementField.DateObserved?.ToString(),
                    LineNumber,
                    nameof(settlementField.DateObserved).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    settlementField.Population?.ToString(),
                    LineNumber,
                    nameof(settlementField.Population).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    settlementField.Happiness?.ToString(),
                    LineNumber,
                    nameof(settlementField.Happiness).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    settlementField.Productivity?.ToString(),
                    LineNumber,
                    nameof(settlementField.Productivity).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    settlementField.Maintenance?.ToString(),
                    LineNumber,
                    nameof(settlementField.Maintenance).GetDescription<SettlementImport>(),
                    SheetName),
                new NullableIntFieldStrategy(
                    settlementField.Sentinels?.ToString(),
                    LineNumber,
                    nameof(settlementField.Sentinels).GetDescription<SettlementImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}