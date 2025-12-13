using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class PlanetCsvMap : ClassMap<PlanetImport>
{
    public PlanetCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.AgeOfPlanetInBillionsOfYears)
            .Convert(m =>
            {
                string? value = m.Row.GetField(PlanetSheetFields.AgeOfPlanetInBillionsOfYears);
                return !string.IsNullOrEmpty(value) && int.TryParse(value, out int result) ? result : null;
            });

        Map(m => m.AssignedRawIngredient)
            .Convert(m => m.Row.ReadNullableEnumField<EdibleMaterialTypes>(PlanetSheetFields.AssignedRawIngredient));

        Map(m => m.AtmosphereGas1)
            .Convert(m => m.Row.ReadHarvestedMaterialField(PlanetSheetFields.AtmosphereGas1));

        Map(m => m.AtmosphereGas2)
            .Convert(m => m.Row.ReadHarvestedMaterialField(PlanetSheetFields.AtmosphereGas2));

        Map(m => m.AtmosphereResource)
            .Convert(m => m.Row.ReadHarvestedMaterialField(PlanetSheetFields.AtmosphereResource));

        Map(m => m.AtmosphereGasPercentage1)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.AtmosphereGasPercentage1));

        Map(m => m.AtmosphereGasPercentage2)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.AtmosphereGasPercentage2));

        Map(m => m.AtmosphereDaytimeColor)
            .Convert(m => m.Row.ReadEnumFieldOrNull<AtmosphereColorTypes>(PlanetSheetFields.AtmosphereDaytimeColor));

        Map(m => m.PlanetBiomeDescription)
            .Convert(m => m.Row.ReadEnumFieldOrNull<BiomeSubTypes>(PlanetSheetFields.PlanetBiomeDescription));

        Map(m => m.BiomeResource).Convert(m => m.Row.ReadHarvestedMaterialField(PlanetSheetFields.BiomeResource));

        Map(m => m.PlanetBiomeType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<BiomeTypes>(PlanetSheetFields.PlanetBiomeType));

        Map(m => m.DayRadiation).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayRadiation));

        Map(m => m.DayStormRadiation).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayStormRadiation));

        Map(m => m.DayStormTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayStormTemp));

        Map(m => m.DayStormToxic).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayStormToxic));

        Map(m => m.DayTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayTemp));

        Map(m => m.DayToxic).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.DayToxic));

        Map(m => m.DiscoveryDate).Convert(m => m.Row.ReadDateTimeFieldOrNull(PlanetSheetFields.DiscoveryDate));

        Map(m => m.DiscoveryPlatform)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(PlanetSheetFields.DiscoveryPlatform));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(PlanetSheetFields.DocumentSequence));

        Map(m => m.ExtremeWeatherExcludingMegaExotic)
            .Convert(m =>
                m.Row.ReadEnumFieldOrNull<PlanetExtremeWeatherTypes>(
                    PlanetSheetFields.ExtremeWeatherExcludingMegaExotic));

        Map(m => m.ExtremeWeatherIncludingMegaExotic)
            .Convert(m =>
                m.Row.ReadEnumFieldOrNull<PlanetExtremeWeatherTypes>(
                    PlanetSheetFields.ExtremeWeatherIncludingMegaExotic));

        Map(m => m.Extras).Convert(m => m.Row.ReadEnumFields<UniqueMaterialTypes>(PlanetSheetFields.Extras));

        Map(m => m.FaunaLevelCategory)
            .Convert(m => m.Row.ReadEnumFieldOrNull<PlanetBiotaLevelTypes>(PlanetSheetFields.FaunaLevelCategory));

        Map(m => m.FloraLevelCategory)
            .Convert(m => m.Row.ReadEnumFieldOrNull<PlanetBiotaLevelTypes>(PlanetSheetFields.FloraLevelCategory));

        Map(m => m.HasGarden)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.RingsOrGiant,
                PlanetSheetFields.HasGardenIndicator));

        Map(m => m.GameVersionNumberForPage)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.GameVersionNumberForPage));

        Map(m => m.Geology).Convert(m => m.Row.ReadEnumFieldOrNull<GeologyTypes>(PlanetSheetFields.Geology));

        Map(m => m.Glitches).Convert(m => m.Row.ReadEnumFieldOrNull<GlitchMaterialTypes>(PlanetSheetFields.Glitches));

        Map(m => m.HasSandworms)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.HasSandworms,
                PlanetSheetFields.HasSandwormsIndicator));

        Map(m => m.HasRings)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.RingsOrGiant,
                PlanetSheetFields.HasRingsIndicator));

        Map(m => m.IsGasGiant)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.RingsOrGiant,
                PlanetSheetFields.IsGasGiantIndicator));

        Map(m => m.IsInfected)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.IsInfected,
                PlanetSheetFields.IsInfectedIndicator));

        Map(m => m.IsPlanet)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.PlanetOrMoon,
                PlanetSheetFields.IsPlanetIndicator));

        Map(m => m.IsMoon)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.PlanetOrMoon,
                PlanetSheetFields.IsMoonIndicator));

        Map(m => m.LegacyPCDiscoveryDate)
            .Convert(m => m.Row.ReadDateTimeFieldOrNull(PlanetSheetFields.LegacyPCDiscoveryDate));

        Map(m => m.LegacyPSDiscoveryDate)
            .Convert(m => m.Row.ReadDateTimeFieldOrNull(PlanetSheetFields.LegacyPSDiscoveryDate));

        Map(m => m.LegacyXboxDiscoveryDate)
            .Convert(m => m.Row.ReadDateTimeFieldOrNull(PlanetSheetFields.LegacyXboxDiscoveryDate));

        Map(m => m.GameModeType).Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(PlanetSheetFields.GameModeType));

        Map(m => m.NightStormTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.NightStormTemp));

        Map(m => m.NightTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.NightTemp));

        Map(m => m.NumberOfFauna).Convert(m => m.Row.ReadIntFieldOrNull(PlanetSheetFields.NumberOfFauna));

        Map(m => m.PlanetOrMoonAddedInOrigins)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlanetSheetFields.PlanetOrMoonAddedInOrigins,
                PlanetSheetFields.PlanetOrMoonAddedInOriginsIndicator));

        Map(m => m.PlanetIdInSystem).Convert(m => m.Row.ReadIntFieldOrNull(PlanetSheetFields.PlanetIdInSystem));

        Map(m => m.PrimaryCoreElement)
            .Convert(m => m.Row.ReadEnumFieldOrNull<PlanetaryCoreTypes>(PlanetSheetFields.PrimaryCoreElement));

        Map(m => m.Extras).Convert(m => m.Row.ReadEnumFields<UniqueMaterialTypes>(PlanetSheetFields.Extras));

        Map(m => m.PrimaryResource).Convert(m => m.Row.ReadHarvestedMaterialFields(PlanetSheetFields.PrimaryResource));

        Map(m => m.RawIngredients)
            .Convert(m => m.Row.ReadEnumFields<EdibleMaterialTypes>(PlanetSheetFields.RawIngredients));

        Map(m => m.SentinelActivity)
            .Convert(m => m.Row.ReadEnumFieldOrNull<SentinelActivityTypes>(PlanetSheetFields.SentinelActivity));

        Map(m => m.SpecialResource)
            .Convert(m => m.Row.ReadEnumFields<PlanetPropertyTypes>(PlanetSheetFields.SpecialResource));

        Map(m => m.PlanetTerrain)
            .Convert(m => m.Row.ReadEnumFieldOrNull<TerrainTypes>(PlanetSheetFields.PlanetTerrain));

        Map(m => m.PlanetLandType).Convert(m => m.Row.ReadEnumFieldOrNull<LandTypes>(PlanetSheetFields.PlanetLandType));

        Map(m => m.ArchetypeOfLand)
            .Convert(m => m.Row.ReadEnumFieldOrNull<LandArchetypes>(PlanetSheetFields.ArchetypeOfLand));

        Map(m => m.PlanetWeather)
            .Convert(m => m.Row.ReadEnumFieldOrNull<WeatherTypes>(PlanetSheetFields.PlanetWeather));

        Map(m => m.UndergroundDayRadiation)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayRadiation));

        Map(m => m.UndergroundDayStormRadiation)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayStormRadiation));

        Map(m => m.UndergroundDayStormTemp)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayStormTemp));

        Map(m => m.UndergroundDayStormToxic)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayStormToxic));

        Map(m => m.UndergroundDayTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayTemp));

        Map(m => m.UndergroundDayToxic).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundDayToxic));

        Map(m => m.UndergroundNightStormTemp)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundNightStormTemp));

        Map(m => m.UndergroundNightTemp)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UndergroundNightTemp));

        Map(m => m.UnderwaterDayRadiation)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayRadiation));

        Map(m => m.UnderwaterDayStormRadiation)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayStormRadiation));

        Map(m => m.UnderwaterDayStormTemp)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayStormTemp));

        Map(m => m.UnderwaterDayStormToxic)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayStormToxic));

        Map(m => m.UnderwaterDayTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayTemp));

        Map(m => m.UnderwaterDayToxic).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterDayToxic));

        Map(m => m.UnderwaterNightStormTemp)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterNightStormTemp));

        Map(m => m.UnderwaterNightTemp).Convert(m => m.Row.ReadFloatFieldOrNull(PlanetSheetFields.UnderwaterNightTemp));

        Map(m => m.PlanetWeather)
            .Convert(m => m.Row.ReadEnumFieldOrNull<WeatherTypes>(PlanetSheetFields.PlanetWeather));
    }
}