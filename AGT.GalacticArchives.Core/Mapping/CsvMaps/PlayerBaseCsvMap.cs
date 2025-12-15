using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class PlayerBaseCsvMap : ClassMap<PlayerBaseImport>
{
    public PlayerBaseCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.PlayerBaseId).Convert(m => m.Row.ReadGuidFieldOrNull(PlayerBaseSheetFields.PlayerBaseId));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(PlayerBaseSheetFields.RegionId));

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(PlayerBaseSheetFields.StarSystemId));

        Map(m => m.PlanetId).Convert(m => m.Row.ReadGuidFieldOrNull(PlayerBaseSheetFields.PlanetId));

        Map(m => m.AccessOrTerrainSituation)
            .Convert(m =>
                m.Row.ReadEnumFieldOrNull<PlayerBaseTerrainTypes>(PlayerBaseSheetFields.AccessOrTerrainSituation));

        Map(m => m.AllowsDeconstruction)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.AllowsDeconstruction,
                PlayerBaseSheetFields.AllowsDeconstructionIndicator));

        Map(m => m.AestheticsRating).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.AestheticsRating));

        Map(m => m.BaseComplexity).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.BaseComplexity));

        Map(m => m.BaseElements)
            .Convert(m => m.Row.ReadEnumFields<PlayerBaseElementTypes>(PlayerBaseSheetFields.BaseElements));

        Map(m => m.PlayerBaseClassification)
            .Convert(m =>
                m.Row.ReadEnumFieldOrNull<PlayerBaseClassificationTypes>(
                    PlayerBaseSheetFields.PlayerBaseClassification));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.DocumentSequence));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(PlayerBaseSheetFields.Galaxy));

        Map(m => m.GasExtractorContents)
            .Convert(m => m.Row.ReadEnumFields<AtmosphereGasTypes>(PlayerBaseSheetFields.GasExtractorContents));

        Map(m => m.GasExtractorCapacity)
            .Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.GasExtractorCapacity));

        Map(m => m.HasArena)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasArena,
                PlayerBaseSheetFields.HasArenaIndicator));

        Map(m => m.HasFarm)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasFarm,
                PlayerBaseSheetFields.HasFarmIndicator));

        Map(m => m.HasGeoBay)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasGeoBay,
                PlayerBaseSheetFields.HasGeoBayIndicator));

        Map(m => m.HasLandingPad)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasLandingPad,
                PlayerBaseSheetFields.HasLandingPadIndicator));

        Map(m => m.HasRacetrack)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasRacetrack,
                PlayerBaseSheetFields.HasRacetrackIndicator));

        Map(m => m.HasTradeTerminal)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.HasTradeTerminal,
                PlayerBaseSheetFields.HasTradeTerminalIndicator));

        Map(m => m.MineralExtractorContents)
            .Convert(m => m.Row.ReadEnumFields<HarvestedMaterialTypes>(PlayerBaseSheetFields.MineralExtractorContents));

        Map(m => m.GameModeType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(PlayerBaseSheetFields.GameModeType));

        Map(m => m.GamePlatformType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(PlayerBaseSheetFields.GamePlatformType));

        Map(m => m.NearByPointsOfInterest)
            .Convert(m => m.Row.ReadEnumFields<LocationTypes>(PlayerBaseSheetFields.NearByPointsOfInterest));

        Map(m => m.PowerSituation)
            .Convert(m => m.Row.ReadEnumFieldOrNull<PlayerBasePowerTypes>(PlayerBaseSheetFields.PowerSituation));

        Map(m => m.TypeOfBase)
            .Convert(m => m.Row.ReadEnumFieldOrNull<PlayerBaseTypes>(PlayerBaseSheetFields.PowerSituation));

        Map(m => m.MineralExtractorCapacity)
            .Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.MineralExtractorCapacity));

        Map(m => m.SurveyDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(PlayerBaseSheetFields.SurveyDate));

        Map(m => m.YAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlayerBaseSheetFields.YAxisPlanetCoordinate));

        Map(m => m.XAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlayerBaseSheetFields.XXSecondCoordinate));
    }
}