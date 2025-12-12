using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
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

        Map(m => m.Category)
            .Convert(m => m.Row.ReadEnumFieldOrNull<MultiToolCategoryTypes>(MultiToolSheetFields.Category));

        Map(m => m.Class).Convert(m => m.Row.ReadEnumFieldOrNull<ItemClassTypes>(MultiToolSheetFields.Class));

        Map(m => m.Cost).Convert(m => m.Row.ReadIntFieldOrNull(MultiToolSheetFields.Class));

        Map(m => m.Damage).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.Damage));

        Map(m => m.DiscoveryDate).Convert(m => m.Row.ReadDateTimeFieldOrNull(MultiToolSheetFields.DiscoveryDate));

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

        Map(m => m.GameModeType).Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(MultiToolSheetFields.GameModeType));

        Map(m => m.Platform).Convert(m => m.Row.ReadEnumFieldOrNull<GamePlatformTypes>(MultiToolSheetFields.Platform));

        Map(m => m.PrimaryColor)
            .Convert(m => m.Row.ReadEnumFieldOrNull<ItemColorTypes>(MultiToolSheetFields.PrimaryColor));

        Map(m => m.Scanner).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.Scanner));

        Map(m => m.SecondaryColor)
            .Convert(m => m.Row.ReadEnumFieldOrNull<ItemColorTypes>(MultiToolSheetFields.SecondaryColor));

        Map(m => m.TechSlots).Convert(m => m.Row.ReadIntFieldOrNull(MultiToolSheetFields.TechSlots));

        Map(m => m.MultiToolType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<MultiToolTypes>(MultiToolSheetFields.MultiToolType));

        Map(m => m.XXSecondCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.XXSecondCoordinate));

        Map(m => m.YYFirstCoordinate).Convert(m => m.Row.ReadFloatFieldOrNull(MultiToolSheetFields.YYFirstCoordinate));
    }
}