using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class StarshipCsvMap : BaseCsvMap<StarshipImport>
{
    public StarshipCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Class)
            .Convert(m => GetEnumValueFromCsvField<QualityClassTypes>(m.Row.GetField(StarshipSheetFields.ModelType), m));

        Map(m => m.ExtraHullAccessories)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.ExtraHullAccessories);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<StarshipExtraHullAccessoryTypes>(value, m)
                    : null;
            });

        Map(m => m.Damage)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Damage);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.GamePlatformType)
            .Convert(m => GetEnumValueFromCsvField<GamePlatformType>(m.Row.GetField(StarshipSheetFields.GamePlatform), m));

        Map(m => m.GameMode)
            .Convert(m => GetEnumValueFromCsvField<GameModeTypes>(m.Row.GetField(StarshipSheetFields.GameMode), m));

        Map(m => m.HullAccessories)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.HullAccessories);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<StarshipHullAccessoryTypes>(value, m)
                    : null;
            });

        Map(m => m.InventorySize)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.InventorySize);
                return string.IsNullOrEmpty(value) ? GetEnumValueFromCsvField<InventorySizeTypes>(value, m) : null;
            });

        Map(m => m.Maneuver)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Maneuver);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.ModelType)
            .Convert(m =>
                GetEnumValueFromCsvField<StarshipModelTypes>(m.Row.GetField(StarshipSheetFields.ModelType), m));

        Map(m => m.Shield)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Shield);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.SubType)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Subtype);
                return string.IsNullOrEmpty(value) ? GetEnumValueFromCsvField<StarshipSubModelTypes>(value, m) : null;
            });

        Map(m => m.Thruster)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Thruster);
                return string.IsNullOrEmpty(value) ? GetEnumValueFromCsvField<StarshipThrusterTypes>(value, m) : null;
            });

        Map(m => m.Warp)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.Warp);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.WingType)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarshipSheetFields.WingType);
                return string.IsNullOrEmpty(value) ? GetEnumValueFromCsvField<StarshipWingTypes>(value, m) : null;
            });

        Map(m => m.StarshipUpgradeModules)
            .Convert(m =>
                GetEnumValuesFromCsvColumns<StarshipUpgradeModuleTypes>(StarshipSheetFields.UpgradeModules, m));
    }
}