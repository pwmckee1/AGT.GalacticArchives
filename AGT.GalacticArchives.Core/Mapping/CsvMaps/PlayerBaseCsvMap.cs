using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
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

        Map(m => m.AccessOrTerrainSituation)
            .Convert(m =>
                m.Row.ReadEnumFieldOrNull<PlayerBaseTerrainTypes>(PlayerBaseSheetFields.AccessOrTerrainSituation));

        Map(m => m.AllowsDeconstruction)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                PlayerBaseSheetFields.AllowsDeconstruction,
                PlayerBaseSheetFields.AllowsDeconstructionIndicator));

        Map(m => m.Aesthetics).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.Aesthetics));

        Map(m => m.BaseComplexity).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.BaseComplexity));

        Map(m => m.BaseElements)
            .Convert(m => m.Row.ReadEnumFields<PlayerBaseElementTypes>(PlayerBaseSheetFields.BaseElements));

        Map(m => m.BaseType).Convert(m => m.Row.ReadEnumFieldOrNull<PlayerBaseTypes>(PlayerBaseSheetFields.BaseType));

        Map(m => m.DateFinished).Convert(m => m.Row.ReadDateTimeFieldOrNull(PlayerBaseSheetFields.DateFinished));

        Map(m => m.DateOfSurvey).Convert(m => m.Row.ReadDateTimeFieldOrNull(PlayerBaseSheetFields.DateOfSurvey));

        Map(m => m.DateStarted).Convert(m => m.Row.ReadDateTimeFieldOrNull(PlayerBaseSheetFields.DateStarted));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.DocumentSequence));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(PlayerBaseSheetFields.Galaxy));

        Map(m => m.GasStoreCapacity).Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.GasStoreCapacity));

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

        Map(m => m.MiningExtractorMaterial)
            .Convert(m => m.Row.ReadHarvestedMaterialField(PlayerBaseSheetFields.MiningExtractorMaterial));

        Map(m => m.MiningStoreCapacity)
            .Convert(m => m.Row.ReadIntFieldOrNull(PlayerBaseSheetFields.MiningStoreCapacity));

        Map(m => m.YYFirstCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlayerBaseSheetFields.YYFirstCoordinate));

        Map(m => m.XXSecondCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(PlayerBaseSheetFields.XXSecondCoordinate));
    }
}