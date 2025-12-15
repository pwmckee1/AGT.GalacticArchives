using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class PointOfInterestImport : IImportFormFile
{
    [Name(PointOfInterestSheetFields.PointOfInterestId)]
    public Guid? PointOfInterestId { get; set; }

    [Name(PointOfInterestSheetFields.SurveyDate)]
    public DateTimeOffset? SurveyDate { get; set; }

    [Name(PointOfInterestSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(PointOfInterestSheetFields.PointOfInterestName)]
    public string? PointOfInterestName { get; set; }

    [Name(PointOfInterestSheetFields.NotesOrDescription)]
    public string? NotesOrDescription { get; set; }

    [Name(PointOfInterestSheetFields.Planet)]
    public string? PlanetName { get; set; }

    [Name(PointOfInterestSheetFields.Region)]
    public string? RegionName { get; set; }

    [Name(PointOfInterestSheetFields.Release)]
    public string? Release { get; set; }

    [Name(PointOfInterestSheetFields.SurveyedBy)]
    public string? SurveyedBy { get; set; }

    [Name(PointOfInterestSheetFields.StarSystemName)]
    public string? StarSystemName { get; set; }

    [Name(PointOfInterestSheetFields.LocationType)]
    public LocationTypes? LocationType { get; set; }

    [Name(PointOfInterestSheetFields.XAxisPlanetCoordinate)]
    public float? XAxisPlanetCoordinate { get; set; }

    [Name(PointOfInterestSheetFields.YAxisPlanetCoordinate)]
    public float? YAxisPlanetCoordinate { get; set; }

    [Name(PointOfInterestSheetFields.DocumentSequence)]
    public float? DocumentSequence { get; set; }

    [Name(PointOfInterestSheetFields.RegionId)]
    public Guid? RegionId { get; set; }

    [Name(PointOfInterestSheetFields.StarSystemId)]
    public Guid? StarSystemId { get; set; }

    [Name(PointOfInterestSheetFields.PlanetId)]
    public Guid? PlanetId { get; set; }
}