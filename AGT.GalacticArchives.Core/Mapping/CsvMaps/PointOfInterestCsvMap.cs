using System.Globalization;
using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using AGT.GalacticArchives.Core.Models.GoogleSheetImports;
using CsvHelper.Configuration;

namespace AGT.GalacticArchives.Core.Mapping.CsvMaps;

public sealed class PointOfInterestCsvMap : ClassMap<PointOfInterestImport>
{
    public PointOfInterestCsvMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.PointOfInterestId)
            .Convert(m => m.Row.ReadGuidFieldOrNull(PointOfInterestSheetFields.PointOfInterestId));

        Map(m => m.Galaxy).Convert(m => m.Row.ReadEnumFieldOrNull<GalaxyTypes>(PointOfInterestSheetFields.Galaxy));

        Map(m => m.RegionId).Convert(m => m.Row.ReadGuidFieldOrNull(PointOfInterestSheetFields.RegionId));

        Map(m => m.StarSystemId).Convert(m => m.Row.ReadGuidFieldOrNull(PointOfInterestSheetFields.StarSystemId));

        Map(m => m.PlanetId).Convert(m => m.Row.ReadGuidFieldOrNull(PointOfInterestSheetFields.PlanetId));

        Map(m => m.LocationType)
            .Convert(m => m.Row.ReadEnumFieldOrNull<LocationTypes>(PointOfInterestSheetFields.LocationType));

        Map(m => m.DocumentSequence)
            .Convert(m => m.Row.ReadIntFieldOrNull(PointOfInterestSheetFields.DocumentSequence));

        Map(m => m.YAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadIntFieldOrNull(PointOfInterestSheetFields.YAxisPlanetCoordinate));

        Map(m => m.XAxisPlanetCoordinate)
            .Convert(m => m.Row.ReadIntFieldOrNull(PointOfInterestSheetFields.XAxisPlanetCoordinate));

        Map(m => m.SurveyDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(PointOfInterestSheetFields.SurveyDate));

        Map(m => m.SurveyDate).Convert(m => m.Row.ReadDateTimeOffsetFieldOrNull(PointOfInterestSheetFields.SurveyDate));
    }
}