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

public sealed class SettlementCsvMap : ClassMap<SettlementImport>
{
    public SettlementCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.SettlementId).Convert(m => m.Row.ReadGuidFieldOrNull(SettlementSheetFields.SettlementId));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(SettlementSheetFields.RegionId));

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(SettlementSheetFields.StarSystemId));

        Map(m => m.PlanetId).Convert(m => m.Row.ReadGuidFieldOrNull(SettlementSheetFields.PlanetId));

        Map(m => m.YAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(SettlementSheetFields.YAxisPlanetCoordinate));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.DocumentSequence));

        Map(m => m.XAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadFloatFieldOrNull(SettlementSheetFields.XAxisPlanetCoordinate));

        Map(m => m.Economy).Convert(m => m.Row.ReadEnumFieldOrNull<EconomyTypes>(SettlementSheetFields.Economy));

        Map(m => m.Class).Convert(m => m.Row.ReadEnumFieldOrNull<ItemClassTypes>(SettlementSheetFields.Class));

        Map(m => m.Population).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.Population));

        Map(m => m.Happiness).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.Happiness));

        Map(m => m.Productivity).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.Productivity));

        Map(m => m.Maintenance).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.Maintenance));

        Map(m => m.Sentinels).Convert(m => m.Row.ReadIntFieldOrNull(SettlementSheetFields.Sentinels));

        Map(m => m.IsProfitable)
            .Convert(m => m.Row.ReadBoolFieldOrNull(
                SettlementSheetFields.IsProfitable,
                SettlementSheetFields.IsProfitableIndicator));

        Map(m => m.Buildings)
            .Convert(m => m.Row.ReadEnumFields<SettlementBuildingTypes>(SettlementSheetFields.Buildings));

        Map(m => m.GameModeType).Convert(m => m.Row.ReadEnumFieldOrNull<GameModeTypes>(SettlementSheetFields.GameModeType));
    }
}