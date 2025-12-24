using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GameEntities;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Core.Strategies;
using AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public class RegionImportValidationHandler : BaseImportValidationHandler, IImportValidationHandler
{
    protected override string SheetName => ImportResource.RegionSheetName;

    public bool CanHandle<T>()
    {
        return typeof(T) == typeof(RegionImport);
    }

    public HashSet<string> Handle<T>(HashSet<T> importRecords, HashSet<string> errors)
    {
        if (importRecords is not HashSet<RegionImport> regionDbRecords)
        {
            throw new InvalidCastException(string.Format(ImportResource.UnableToImportError, nameof(Region)));
        }

        foreach (var regionField in regionDbRecords)
        {
            var strategies = new HashSet<IExecutionStrategy>
            {
                new EnumFieldTypeStrategy<GalaxyTypes>(
                    regionField.Galaxy?.ToString(),
                    LineNumber,
                    nameof(regionField.Galaxy).GetDescription<RegionImport>(),
                    SheetName),
                new NullFieldStrategy(
                    regionField.RegionName,
                    LineNumber,
                    nameof(regionField.RegionName).GetDescription<RegionImport>(),
                    SheetName),
            };

            ValidateStrategies(strategies, errors);
            LineNumber++;
        }

        return errors;
    }
}