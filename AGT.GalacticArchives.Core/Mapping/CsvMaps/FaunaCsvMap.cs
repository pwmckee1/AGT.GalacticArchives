using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
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

        Map(m => m.FaunaId).Convert(m => m.Row.ReadGuidFieldOrNull(FaunaSheetFields.FaunaId));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(FaunaSheetFields.RegionId));

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(FaunaSheetFields.StarSystemId));

        Map(m => m.PlanetId).Convert(m => m.Row.ReadGuidFieldOrNull(FaunaSheetFields.PlanetId));

        Map(m => m.ActivityType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaCircadianTypes>(FaunaSheetFields.ActivityType));

        Map(m => m.FaunaBaitType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaBaitTypes>(FaunaSheetFields.FaunaBaitType));

        Map(m => m.BehaviourType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaBehaviorTypes>(FaunaSheetFields.BehaviourType));

        Map(m => m.BehaviourArchetype)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaBehaviorArchetypes>(FaunaSheetFields.BehaviourArchetype));

        Map(m => m.FaunaDietType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaDietTypes>(FaunaSheetFields.FaunaDietType));

        Map(m => m.FaunaDietArchetype)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaDietArchetypes>(FaunaSheetFields.FaunaDietArchetype));

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

        Map(m => m.HemisphereType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<HemisphereTypes>(FaunaSheetFields.HemisphereType));

        Map(m => m.GameModeType).Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(FaunaSheetFields.GameModeType));

        Map(m => m.ProductionType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaProductionTypes>(FaunaSheetFields.ProductionType));

        Map(m => m.FaunaInGameNotes)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaInGameNoteTypes>(FaunaSheetFields.FaunaInGameNotes));

        Map(m => m.DiscoveryDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(FaunaSheetFields.DiscoveryDate));

        Map(m => m.FaunaRarityType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<FaunaRarityTypes>(FaunaSheetFields.FaunaRarityType));
    }
}