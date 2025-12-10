using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class StarSystemCsvMap : BaseCsvMap<StarSystemImport>
{
    public StarSystemCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Bases)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.Bases);
                return !string.IsNullOrEmpty(value) && int.TryParse(value, out int result) ? result : null;
            });

        Map(m => m.Buy)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.Buy);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.ConflictType)
            .Convert(m => GetEnumValueFromCsvField<ConflictTypes>(
                m.Row.GetField(StarSystemSheetFields.ConflictType),
                m));

        Map(m => m.EconomyType)
            .Convert(m => GetEnumValueFromCsvField<EconomyTypes>(
                m.Row.GetField(StarSystemSheetFields.EconomyType),
                m));

        Map(m => m.SuitUpgradeModules)
            .Convert(m =>
                GetEnumValuesFromCsvColumns<ExoSuitUpgradeTypes>(StarSystemResource.SuitUpgradeModules, m));

        Map(m => m.Faction)
            .Convert(m => GetEnumValueFromCsvField<FactionTypes>(StarSystemSheetFields.Faction, m));

        Map(m => m.GalaxySequence)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.GalaxySequence);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.GameModeType)
            .Convert(m => GetEnumValueFromCsvField<GameModeTypes>(StarSystemSheetFields.GameModeType, m));

        Map(m => m.GameReleaseVersionNumber)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.GameReleaseVersionNumber);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.HasWater)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.HasWater);
                return value?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.Hex2DecSystemId)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.Hex2DecSystemId);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.IsDissonant)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.IsDissonant);
                return value?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsGiantSystem)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.IsGiantSystem);
                return value?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsPhantomSystem)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.IsPhantomSystem);
                return value?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.LightYearsFromCenter)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.LightYearsFromCenter);
                return !string.IsNullOrEmpty(value) && int.TryParse(value, out int result) ? result : null;
            });

        Map(m => m.LightYearsFromCenterAutoEstimate)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.LightYearsFromCenterAutoEstimate);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.MultiToolSClassUpgradeModules)
            .Convert(m => GetEnumValuesFromCsvColumns<MultiToolUpdateTypes>(
                StarSystemResource.MultiToolSClassUpgradeModules,
                m));

        Map(m => m.NumberOfMoons)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.NumberOfMoons);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.NumberOfPlanets)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.NumberOfPlanets);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.Sell)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.Sell);
                return float.TryParse(value, out float result) ? result : 0;
            });

        Map(m => m.StarSystemShipUpgradeModules)
            .Convert(m => GetEnumValuesFromCsvColumns<StarshipUpgradeTypes>(
                StarSystemResource.StarSystemShipUpgradeModules,
                m));

        Map(m => m.SpaceStationTradeItems)
            .Convert(m =>
                GetEnumValuesFromCsvColumns<SpaceStationTradeItemTypes>(
                    StarSystemResource.SpaceStationTradeItems,
                    m));

        Map(m => m.StarCount)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.StarCount);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.WealthType)
            .Convert(m => GetEnumValueFromCsvField<WealthTypes>(StarSystemSheetFields.WealthType, m));

        Map(m => m.XCoordDec)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.XCoordDec);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.YCoordDec)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.YCoordDec);
                return int.TryParse(value, out int result) ? result : 0;
            });

        Map(m => m.ZCoordDec)
            .Convert(m =>
            {
                string? value = m.Row.GetField(StarSystemSheetFields.ZCoordDec);
                return int.TryParse(value, out int result) ? result : 0;
            });
    }
}