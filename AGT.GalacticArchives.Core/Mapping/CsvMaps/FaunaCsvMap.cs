using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class FaunaCsvMap : ClassMap<FaunaImport>
{
    public FaunaCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.ActivityType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaCircadianTypes>(FaunaSheetFields.ActivityType));

        Map(m => m.BehaviourType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaBehaviorTypes>(FaunaSheetFields.BehaviourType));

        Map(m => m.BehaviourArchetype)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaBehaviorArchetypes>(FaunaSheetFields.BehaviourArchetype));

        Map(m => m.FaunaDietType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaDietTypes>(FaunaSheetFields.FaunaDietType));

        Map(m => m.FaunaDietArchetype)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaDietArchetypes>(FaunaSheetFields.FaunaDietArchetype));

        Map(m => m.DiscoveredDate).Convert(m => m.Row.ReadDateTimeFieldOrNull(FaunaSheetFields.DiscoveredDate));

        Map(m => m.GamePlatformType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(FaunaSheetFields.GamePlatformType));

        Map(m => m.DiscoveryScreenHeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.DiscoveryScreenHeight));

        Map(m => m.DiscoveryScreenWeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.DiscoveryScreenWeight));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(FaunaSheetFields.DocumentSequence));

        Map(m => m.EcosystemType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaEcosystemTypes>(FaunaSheetFields.EcosystemType));

        Map(m => m.IsExtinct)
            .Convert(m => m.Row.ReadBoolFieldOrNull(FaunaSheetFields.IsExtinct, FaunaSheetFields.IsExtinctIndicator));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(FaunaSheetFields.Galaxy));

        Map(m => m.Gender1).Convert(m => m.Row.ReadEnumFieldOrNull<FaunaGenderTypes>(FaunaSheetFields.Gender1));

        Map(m => m.Gender2).Convert(m => m.Row.ReadEnumFieldOrNull<FaunaGenderTypes>(FaunaSheetFields.Gender2));

        Map(m => m.Gender1ScanMaxHeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.Gender1ScanMaxHeight));

        Map(m => m.Gender1ScanMaxWeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.Gender1ScanMaxWeight));

        Map(m => m.Gender2ScanMaxHeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.Gender2ScanMaxHeight));

        Map(m => m.Gender2ScanMaxWeight)
            .Convert(m => m.Row.ReadFloatFieldOrNull(FaunaSheetFields.Gender2ScanMaxWeight));

        Map(m => m.GenusType).Convert(m => m.Row.ReadEnumFieldOrNull<FaunaGenusTypes>(FaunaSheetFields.GenusType));

        Map(m => m.GenusSubtype)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaGenusSubtypes>(FaunaSheetFields.GenusSubtype));

        Map(m => m.HemisphereType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<HemisphereTypes>(FaunaSheetFields.HemisphereType));

        Map(m => m.LegacyFaunaDatePC).Convert(m => m.Row.ReadDateTimeFieldOrNull(FaunaSheetFields.LegacyFaunaDatePC));

        Map(m => m.LegacyFaunaDatePS).Convert(m => m.Row.ReadDateTimeFieldOrNull(FaunaSheetFields.LegacyFaunaDatePS));

        Map(m => m.LegacyFaunaDateXbox)
            .Convert(m => m.Row.ReadDateTimeFieldOrNull(FaunaSheetFields.LegacyFaunaDateXbox));

        Map(m => m.GameModeType).Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(FaunaSheetFields.GameModeType));

        Map(m => m.ProductionType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaProductionTypes>(FaunaSheetFields.ProductionType));

        Map(m => m.FaunaRarityType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaRarityTypes>(FaunaSheetFields.FaunaRarityType));
    }
}