using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class PointOfInterestCsvMap : ClassMap<PointOfInterestImport>
{
    public PointOfInterestCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.LocationType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<LocationTypes>(PointOfInterestSheetFields.LocationType));

        Map(m => m.YYFirstCoordinate)
            .Convert(m => m.Row.ReadIntFieldOrNull(PointOfInterestSheetFields.YYFirstCoordinate));

        Map(m => m.XXSecondCoordinate)
            .Convert(m => m.Row.ReadIntFieldOrNull(PointOfInterestSheetFields.XXSecondCoordinate));

        Map(m => m.DateOfSurvey).Convert(m => m.Row.ReadDateTimeFieldOrNull(PointOfInterestSheetFields.DateOfSurvey));

        Map(m => m.DateOfSurvey).Convert(m => m.Row.ReadDateTimeFieldOrNull(PointOfInterestSheetFields.DateOfSurvey));
    }
}