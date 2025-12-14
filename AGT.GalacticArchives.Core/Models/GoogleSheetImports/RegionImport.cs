using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class RegionImport : IImportFormFile
{
    [Name(RegionSheetFields.RegionId)]
    public Guid? RegionId { get; set; }

    [Name(RegionSheetFields.AdminNotes)]
    public string? AdminNotes { get; set; }

    [Name(RegionSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(RegionSheetFields.AutoSurveyDate)]
    public DateTime? AutoSurveyDate { get; set; }

    [Name(RegionSheetFields.BaseCoordinates)]
    public string? BaseCoordinates { get; set; }

    [Name(RegionSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(RegionSheetFields.CivilizedSpaceNotes)]
    public string? CivilizedSpaceNotes { get; set; }

    [Name(RegionSheetFields.GalacticCoordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(RegionSheetFields.DocumentSequence)]
    public int? DocumentSequence { get; set; }

    [Name(RegionSheetFields.EarliestKnownSurveyor)]
    public string? EarliestKnownSurveyor { get; set; }

    [Name(RegionSheetFields.EarliestSurveyorWikiUser)]
    public string? EarliestSurveyorWikiUser { get; set; }

    [Name(RegionSheetFields.EarliestSystemDiscovery)]
    public DateTime? EarliestSystemDiscovery { get; set; }

    [Name(RegionSheetFields.ExternalLink1)]
    public string? ExternalLink1 { get; set; }

    [Name(RegionSheetFields.GalaxySequence)]
    public int? GalaxySequence { get; set; }

    [Name(RegionSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(RegionSheetFields.GlyphHexCode)]
    public string? GlyphHexCode { get; set; }

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
    public int? LightYearsFromCenter { get; set; }

    [Name(RegionSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    [Name(RegionSheetFields.LowestKnownPhantomSystem)]
    public string? LowestKnownPhantomSystem { get; set; }

    [Name(RegionSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(RegionSheetFields.GalacticQuadrant)]
    public GalacticQuadrantTypes? GalacticQuadrant { get; set; }

    [Name(RegionSheetFields.RegionAge)]
    public float? RegionAge { get; set; }

    [Name(RegionSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(RegionSheetFields.VideoLink1)]
    public string? VideoLink1 { get; set; }

    [Name(RegionSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(RegionSheetFields.XXHex)]
    public string? XXHex { get; set; }

    [Name(RegionSheetFields.XXDec)]
    public int? XXDec { get; set; }

    [Name(RegionSheetFields.YYAltitude)]
    public string? YYHex { get; set; }

    [Name(RegionSheetFields.YYDec)]
    public int? YYDec { get; set; }

    [Name(RegionSheetFields.ZZHex)]
    public string? ZZHex { get; set; }

    [Name(RegionSheetFields.ZZDec)]
    public int? ZZDec { get; set; }

    [Name(RegionSheetFields.GameReleaseVersionNumber)]
    public string? GameReleaseVersionNumber { get; set; }
}