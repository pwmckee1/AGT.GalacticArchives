using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class RegionCsvMap : ClassMap<RegionImport>
{
    public RegionCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(RegionSheetFields.RegionId));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(RegionSheetFields.Galaxy));

        Map(m => m.GalacticQuadrant)
            .Convert(m => m.Row.ReadEnumFieldOrNull<GalacticQuadrantTypes>(RegionSheetFields.GalacticQuadrant));

        Map(m => m.DocumentSequence).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.DocumentSequence));

        Map(m => m.SurveyDate).Convert(m => m.Row.ReadDateTimeFieldOrNull(RegionSheetFields.SurveyDate));

        Map(m => m.RegionAge).Convert(m => m.Row.ReadFloatFieldOrNull(RegionSheetFields.RegionAge));

        Map(m => m.LightYearsFromCenter).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.LightYearsFromCenter));

        Map(m => m.EarliestSystemDiscovery)
            .Convert(m => m.Row.ReadDateTimeFieldOrNull(RegionSheetFields.EarliestSystemDiscovery));

        Map(m => m.XXDec).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.XXDec));

        Map(m => m.YYDec).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.YYDec));

        Map(m => m.ZZDec).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.ZZDec));

        Map(m => m.GalaxySequence).Convert(m => m.Row.ReadIntFieldOrNull(RegionSheetFields.GalaxySequence));
    }
}