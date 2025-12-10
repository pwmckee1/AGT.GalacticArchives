using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class RegionImport : IGoogleSheetImport
{
    [Name(RegionSheetFields.AdminNotes)]
    public string? AdminNotes { get; set; }

    [Name(RegionSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(RegionSheetFields.AutoSurveyDate)]
    public string? AutoSurveyDate { get; set; }

    [Name(RegionSheetFields.BaseCoord)]
    public string? BaseCoordinates { get; set; }

    [Name(RegionSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(RegionSheetFields.CivilizedSpaceNotes)]
    public string? CivilizedSpaceNotes { get; set; }

    public string? Coordinates { get; set; }

    [Name(RegionSheetFields.DocSequence)]
    public string? DocSequence { get; set; }

    [Name(RegionSheetFields.EarliestKnownSurveyor)]
    public string? EarliestKnownSurveyor { get; set; }

    [Name(RegionSheetFields.EarliestSurveyorWikiUser)]
    public string? EarliestSurveyorWikiUser { get; set; }

    [Name(RegionSheetFields.EarliestSystemDiscovery)]
    public string? EarliestSystemDiscovery { get; set; }

    [Name(RegionSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(RegionSheetFields.GalaxyId)]
    public string? GalaxyId { get; set; }

    [Name(RegionSheetFields.GalaxyName)]
    public string? GalaxyName { get; set; }

    public string? Glyphs { get; set; }

    [Name(RegionSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

    [Name(RegionSheetFields.LatestKnownSurveyor)]
    public string? LatestKnownSurveyor { get; set; }

    [Name(RegionSheetFields.LatestSurveyorWikiUser)]
    public string? LatestSurveyorWikiUser { get; set; }

    [Name(RegionSheetFields.LegacyName)]
    public string? LegacyName { get; set; }

    [Name(RegionSheetFields.LegacyWikilink)]
    public string? LegacyWikilink { get; set; }

    [Name(RegionSheetFields.LightYearsFromCenter)]
    public string? LightYearsFromCenter { get; set; }

    [Name(RegionSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    [Name(RegionSheetFields.LowestKnownPhantomSystem)]
    public string? LowestKnownPhantomSystem { get; set; }

    [Name(RegionSheetFields.RegionName)]
    public string? Name { get; set; }

    public string? Quadrant { get; set; }

    [Name(RegionSheetFields.RegionAge)]
    public float? RegionAge { get; set; }

    [Name(RegionSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(RegionSheetFields.VideoLink1)]
    public string? VideoLink1 { get; set; }

    [Name(RegionSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    public string? XX { get; set; }

    [Name(RegionSheetFields.XXDec)]
    public string? XXDec { get; set; }

    [Name(RegionSheetFields.YYAltitude)]
    public string? YYAltitude { get; set; }

    [Name(RegionSheetFields.YYDec)]
    public string? YYDec { get; set; }

    public string? ZZ { get; set; }

    [Name(RegionSheetFields.ZZDec)]
    public string? ZZDec { get; set; }

    public string? Version { get; set; }
}