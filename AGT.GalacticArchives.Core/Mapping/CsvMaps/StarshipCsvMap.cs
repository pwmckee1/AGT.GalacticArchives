using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class StarshipCsvMap : ClassMap<StarshipImport>
{
    public StarshipCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Galaxy).Convert(m => m.Row.ReadNullableEnumField<GalaxyTypes>(StarshipSheetFields.Galaxy));

        Map(m => m.Location)
            .Convert(m => m.Row.ReadNullableEnumField<StarshipLocationTypes>(StarshipSheetFields.Location));

        Map(m => m.YYFirstCoordinate).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.YYFirstCoordinate));

        Map(m => m.XXSecondCoordinate).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.XXSecondCoordinate));

        Map(m => m.StarshipModelType)
            .Convert(m => m.Row.ReadNullableEnumField<StarshipModelTypes>(StarshipSheetFields.StarshipModelType));

        Map(m => m.Subtype)
            .Convert(m => m.Row.ReadNullableEnumField<StarshipSubModelTypes>(StarshipSheetFields.Subtype));

        Map(m => m.WingType).Convert(m => m.Row.ReadNullableEnumField<StarshipWingTypes>(StarshipSheetFields.WingType));

        Map(m => m.HullAccessories)
            .Convert(m => m.Row.ReadNullableEnumField<StarshipHullAccessoryTypes>(StarshipSheetFields.HullAccessories));

        Map(m => m.Thruster)
            .Convert(m => m.Row.ReadNullableEnumField<StarshipThrusterTypes>(StarshipSheetFields.Thruster));

        Map(m => m.ExtraHullAccessories)
            .Convert(m =>
                m.Row.ReadNullableEnumField<StarshipExtraHullAccessoryTypes>(StarshipSheetFields.ExtraHullAccessories));

        Map(m => m.Class).Convert(m => m.Row.ReadNullableEnumField<ItemClassTypes>(StarshipSheetFields.Class));

        Map(m => m.InventorySize)
            .Convert(m => m.Row.ReadNullableEnumField<InventorySizeTypes>(StarshipSheetFields.InventorySize));

        Map(m => m.InventorySlots).Convert(m => m.Row.ReadIntFieldOrNull(StarshipSheetFields.InventorySlots));

        Map(m => m.TechSlots).Convert(m => m.Row.ReadIntFieldOrNull(StarshipSheetFields.InventorySlots));

        Map(m => m.CargoSlots).Convert(m => m.Row.ReadIntFieldOrNull(StarshipSheetFields.CargoSlots));

        Map(m => m.DiscoveredDate).Convert(m => m.Row.ReadDateTimeFieldOrNull(StarshipSheetFields.DiscoveredDate));

        Map(m => m.Cost).Convert(m => m.Row.ReadIntFieldOrNull(StarshipSheetFields.Cost));

        Map(m => m.GameMode).Convert(m => m.Row.ReadNullableEnumField<GameModeTypes>(StarshipSheetFields.GameMode));

        Map(m => m.GamePlatform)
            .Convert(m => m.Row.ReadNullableEnumField<GamePlatformTypes>(StarshipSheetFields.GamePlatform));

        Map(m => m.Damage).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.Damage));

        Map(m => m.Shield).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.Shield));

        Map(m => m.Warp).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.Warp));

        Map(m => m.Maneuver).Convert(m => m.Row.ReadFloatFieldOrNull(StarshipSheetFields.Maneuver));

        Map(m => m.PrimaryColor)
            .Convert(m => m.Row.ReadNullableEnumField<ItemColorTypes>(StarshipSheetFields.PrimaryColor));

        Map(m => m.SecondaryColor)
            .Convert(m => m.Row.ReadNullableEnumField<ItemColorTypes>(StarshipSheetFields.SecondaryColor));

        Map(m => m.AccentColor)
            .Convert(m => m.Row.ReadNullableEnumField<ItemColorTypes>(StarshipSheetFields.AccentColor));

        Map(m => m.StarshipUpgradeModules)
            .Convert(m => m.Row.ReadEnumFields<StarshipUpgradeModuleTypes>(StarshipSheetFields.StarshipUpgradeModules));
    }
}