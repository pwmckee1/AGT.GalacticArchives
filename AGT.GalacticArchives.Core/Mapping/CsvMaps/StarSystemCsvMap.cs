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

public sealed class StarSystemCsvMap : ClassMap<StarSystemImport>
{
    public StarSystemCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(StarSystemSheetFields.StarSystemId));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(StarSystemSheetFields.RegionId));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadNullableEnumField<GalaxyTypes>(StarSystemSheetFields.GalaxyName));

        Map(m => m.Bases).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.Bases));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.DocumentSequence));

        Map(m => m.Buy).Convert(m => m.Row.ReadFloatFieldOrNull(StarSystemSheetFields.Buy));

        Map(m => m.ConflictType)
            .Convert(m => m.Row.ReadNullableEnumField<ConflictTypes>(StarSystemSheetFields.ConflictType));

        Map(m => m.EconomyType)
            .Convert(m => m.Row.ReadNullableEnumField<EconomyTypes>(StarSystemSheetFields.EconomyType));

        Map(m => m.ExosuitUpgradeModules)
            .Convert(m => m.Row.ReadEnumFields<ExoSuitUpgradeModuleTypes>(StarSystemSheetFields.ExosuitUpgradeModules));

        Map(m => m.ExocraftUpgradeModules)
            .Convert(m => m.Row.ReadEnumFields<ExocraftUpgradeModuleTypes>(StarSystemSheetFields.ExocraftUpgradeModules));

        Map(m => m.Faction).Convert(m => m.Row.ReadNullableEnumField<FactionTypes>(StarSystemSheetFields.Faction));

        Map(m => m.GalaxySequence).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.GalaxySequence));

        Map(m => m.GameModeType)
            .Convert(m => m.Row.ReadNullableEnumField<GameModeTypes>(StarSystemSheetFields.GameModeType));

        Map(m => m.HasWater)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                StarSystemSheetFields.HasWater,
                StarSystemSheetFields.HasWaterIdentifier));

        Map(m => m.HasCenterAccess)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                StarSystemSheetFields.HasCenterAccess,
                StarSystemSheetFields.HasCenterAccessIdentifier));

        Map(m => m.SSDec).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.Hex2DecSystemId));

        Map(m => m.IsDissonant)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                StarSystemSheetFields.IsDissonant,
                StarSystemSheetFields.IsDissonantIdentifier));

        Map(m => m.IsGiantSystem)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                StarSystemSheetFields.IsGiantSystem,
                StarSystemSheetFields.IsGiantSystemIdentifier));

        Map(m => m.IsPhantomSystem)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                StarSystemSheetFields.IsPhantomSystem,
                StarSystemSheetFields.IsPhantomSystemIdentifier));

        Map(m => m.DiscoveryDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(StarSystemSheetFields.DiscoveryDate));

        Map(m => m.SurveyDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(StarSystemSheetFields.SurveyDate));

        Map(m => m.LightYearsFromCenter)
            .Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.LightYearsFromCenter));

        Map(m => m.LightYearsFromCenterAutoEstimate)
            .Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.LightYearsFromCenterAutoEstimate));

        Map(m => m.MultiToolUpdateTypes)
            .Convert(m => m.Row.ReadEnumFields<MultiToolUpdateModuleTypes>(StarSystemSheetFields.MultiToolUpdateTypes));

        Map(m => m.Bases).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.Bases));

        Map(m => m.NumberOfMoons).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.NumberOfMoons));

        Map(m => m.NumberOfPlanets).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.NumberOfPlanets));

        Map(m => m.Sell).Convert(m => m.Row.ReadFloatFieldOrNull(StarSystemSheetFields.Sell));

        Map(m => m.StarshipUpgradeModules)
            .Convert(m => m.Row.ReadEnumFields<StarshipUpgradeTypes>(StarSystemSheetFields.StarshipUpgradeModules));

        Map(m => m.SpaceStationTradeItems)
            .Convert(m =>
                m.Row.ReadEnumFields<SpaceStationTradeItemTypes>(StarSystemSheetFields.SpaceStationTradeItems));

        Map(m => m.StarCount).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.StarCount));

        Map(m => m.StarSystemAge).Convert(m => m.Row.ReadFloatFieldOrNull(StarSystemSheetFields.StarSystemAge));

        Map(m => m.WealthType).Convert(m => m.Row.ReadNullableEnumField<WealthTypes>(StarSystemSheetFields.WealthType));

        Map(m => m.XXDec).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.XXDec));

        Map(m => m.YYDec).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.YYDec));

        Map(m => m.ZZDec).Convert(m => m.Row.ReadIntFieldOrNull(StarSystemSheetFields.ZZDec));

        Map(m => m.GamePlatformType).Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(StarSystemSheetFields.GamePlatformType));

        Map(m => m.Color).Convert(m => m.Row.ReadEnumFieldOrNull<StarColorTypes>(StarSystemSheetFields.Color));
    }
}