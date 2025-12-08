using AGT.GalacticArchives.Core.Constants;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.Imports;

public class PointOfInterestImport : IGoogleSheetImport
{
    [Name(PointOfInterestSheetFields.DateOfSurvey)]
    public string? DateOfSurvey { get; set; }

    [Name(PointOfInterestSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(PointOfInterestSheetFields.Name)]
    public string? Name { get; set; }

    [Name(PointOfInterestSheetFields.NotesOrDescription)]
    public string? NotesOrDescription { get; set; }

    [Name(PointOfInterestSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(PointOfInterestSheetFields.Region)]
    public string? Region { get; set; }

    [Name(PointOfInterestSheetFields.Release)]
    public string? Release { get; set; }

    [Name(PointOfInterestSheetFields.Surveyor)]
    public string? Surveyor { get; set; }

    [Name(PointOfInterestSheetFields.System)]
    public string? System { get; set; }

    [Name(PointOfInterestSheetFields.Type)]
    public string? Type { get; set; }

    [Name(PointOfInterestSheetFields.XXSecondCoordinate)]
    public string? XXSecondCoordinate { get; set; }

    [Name(PointOfInterestSheetFields.YYFirstCoordinate)]
    public string? YYFirstCoordinate { get; set; }
}