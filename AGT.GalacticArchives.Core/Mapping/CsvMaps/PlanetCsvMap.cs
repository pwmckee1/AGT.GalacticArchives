using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Imports;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class PlanetCsvMap : BaseCsvMap<PlanetImport>
{
    public PlanetCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.HasRings)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.RingsOrGiant);
                return value?.Equals("Rings", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsGasGiant)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.RingsOrGiant);
                return value?.Equals("Giant", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsInfected)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.IsInfected);
                return value?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsPlanet)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.PlanetOrMoon);
                return value?.Equals("Planet", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.IsMoon)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.PlanetOrMoon);
                return value?.Equals("Moon", StringComparison.OrdinalIgnoreCase) ?? false;
            });

        Map(m => m.GameModeType)
            .Convert(m => GetEnumValueFromCsvField<GameModeTypes>(PlanetSheetFields.GameModeType, m));

        Map(m => m.NightStormTemp)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.NightStormTemp);
                return float.TryParse(value, out float result) ? result : null;
            });

        Map(m => m.NightTemp)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.NightTemp);
                return float.TryParse(value, out float result) ? result : null;
            });

        Map(m => m.GameModeType)
            .Convert(m => GetEnumValueFromCsvField<GameModeTypes>(PlanetSheetFields.GameModeType, m));

        Map(m => m.PlanetBiomeType)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.BiomeType);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetBiomeTypes>(value, m)
                    : null;
            });

        Map(m => m.PlanetBiomeDescription)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.BiomeDescription);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetBiomeDescriptionTypes>(value, m)
                    : null;
            });

        Map(m => m.PlanetTerrain)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.Terrain);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetTerrainTypes>(value, m)
                    : null;
            });

        Map(m => m.PlanetLandType)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.LandType);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetLandTypes>(value, m)
                    : null;
            });

        Map(m => m.ArchetypeOfLand)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.ArchetypeOfLand);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetLandArchetypes>(value, m)
                    : null;
            });

        Map(m => m.PlanetWeather)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.Weather);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetWeatherTypes>(value, m)
                    : null;
            });

        Map(m => m.ExtremeWeatherExcludingMegaExotic)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.ExtremeWeatherExcludingMegaExotic);
                return string.IsNullOrEmpty(value)
                    ? GetEnumValueFromCsvField<PlanetExtremeWeatherTypes>(value, m)
                    : null;
            });
    }
}