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

public sealed class MultiToolCsvMap : ClassMap<MultiToolImport>
{
    public MultiToolCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.MultiToolId).Convert(m => m.Row.ReadGuidFieldOrNull(MultiToolSheetFields.MultiToolId));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(MultiToolSheetFields.RegionId));

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(MultiToolSheetFields.StarSystemId));

        Map(m => m.PlanetId).Convert(m => m.Row.ReadGuidFieldOrNull(MultiToolSheetFields.PlanetId));

        Map(m => m.MultiToolCategory)
            .Convert(m => m.Row.ReadEnumFieldOrNull<MultiToolCategoryTypes>(MultiToolSheetFields.MultiToolCategory));

        Map(m => m.ItemClass).Convert(m => m.Row.ReadEnumFieldOrNull<ItemClassTypes>(MultiToolSheetFields.ItemClass));

        Map(m => m.Cost).Convert(m => m.Row.ReadIntFieldOrNull(MultiToolSheetFields.Cost));

        Map(m => m.Damage).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.Damage));

        Map(m => m.DiscoveryDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(MultiToolSheetFields.DiscoveryDate));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(MultiToolSheetFields.DocumentSequence));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(MultiToolSheetFields.Galaxy));

        Map(m => m.HasCrystals)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                MultiToolSheetFields.HasCrystals,
                MultiToolSheetFields.HasCrystalsIndicator));

        Map(m => m.HasGlowTubes)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                MultiToolSheetFields.HasGlowTubes,
                MultiToolSheetFields.HasGlowTubesIndicator));

        Map(m => m.HasHorns)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                MultiToolSheetFields.HasHorns,
                MultiToolSheetFields.HasHornsIndicator));

        Map(m => m.Location).Convert(m => m.Row.ReadEnumFieldOrNull<LocationTypes>(MultiToolSheetFields.Location));

        Map(m => m.Mining).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.Mining));

        Map(m => m.GameModeType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(MultiToolSheetFields.GameModeType));

        Map(m => m.GamePlatformType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(MultiToolSheetFields.GamePlatformType));

        Map(m => m.PrimaryColor)
            .Convert(m => m.Row.ReadEnumFieldOrNull<ItemColorTypes>(MultiToolSheetFields.PrimaryColor));

        Map(m => m.Scanner).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.Scanner));

        Map(m => m.SecondaryColor)
            .Convert(m => m.Row.ReadEnumFieldOrNull<ItemColorTypes>(MultiToolSheetFields.SecondaryColor));

        Map(m => m.TechSlots).Convert(m => m.Row.ReadIntFieldOrNull(MultiToolSheetFields.TechSlots));

        Map(m => m.MultiToolType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<MultiToolTypes>(MultiToolSheetFields.MultiToolType));

        Map(m => m.XAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.XAxisPlanetCoordinate));

        Map(m => m.YAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.YAxisPlanetCoordinate));
    }
}