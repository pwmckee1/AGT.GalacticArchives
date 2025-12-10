using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class MultiToolImport : IGoogleSheetImport
{
    [Name(MultiToolSheetFields.AcquisitionGuidance)]
    public string? AcquisitionGuidance { get; set; }

    [Name(MultiToolSheetFields.Category)]
    public string? Category { get; set; }

    [Name(MultiToolSheetFields.Class)]
    public string? Class { get; set; }

    [Name(MultiToolSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(MultiToolSheetFields.Coordinates)]
    public string? Coordinates { get; set; }

    [Name(MultiToolSheetFields.Cost)]
    public string? Cost { get; set; }

    [Name(MultiToolSheetFields.Damage)]
    public string? Damage { get; set; }

    [Name(MultiToolSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(MultiToolSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(MultiToolSheetFields.DiscoveryDate)]
    public string? DiscoveryDate { get; set; }

    [Name(MultiToolSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(MultiToolSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(MultiToolSheetFields.HasCrystals)]
    public string? HasCrystals { get; set; }

    [Name(MultiToolSheetFields.HasGlowTubes)]
    public string? HasGlowTubes { get; set; }

    [Name(MultiToolSheetFields.HasHorns)]
    public string? HasHorns { get; set; }

    [Name(MultiToolSheetFields.Location)]
    public string? Location { get; set; }

    [Name(MultiToolSheetFields.Mining)]
    public string? Mining { get; set; }

    [Name(MultiToolSheetFields.Mode)]
    public string? Mode { get; set; }

    [Name(MultiToolSheetFields.Name)]
    public string? Name { get; set; }

    [Name(MultiToolSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(MultiToolSheetFields.Platform)]
    public string? Platform { get; set; }

    [Name(MultiToolSheetFields.PortalGlyphs)]
    public string? PortalGlyphs { get; set; }

    [Name(MultiToolSheetFields.PrimaryColor)]
    public string? PrimaryColor { get; set; }

    [Name(MultiToolSheetFields.Region)]
    public string? Region { get; set; }

    [Name(MultiToolSheetFields.Release)]
    public string? Release { get; set; }

    [Name(MultiToolSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(MultiToolSheetFields.Scanner)]
    public string? Scanner { get; set; }

    [Name(MultiToolSheetFields.SecondaryColor)]
    public string? SecondaryColor { get; set; }

    [Name(MultiToolSheetFields.Slots)]
    public string? Slots { get; set; }

    [Name(MultiToolSheetFields.System)]
    public string? System { get; set; }

    [Name(MultiToolSheetFields.Type)]
    public string? Type { get; set; }

    [Name(MultiToolSheetFields.UserNotes)]
    public string? UserNotes { get; set; }

    [Name(MultiToolSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(MultiToolSheetFields.XXSecondCoordinate)]
    public string? XXSecondCoordinate { get; set; }

    [Name(MultiToolSheetFields.YYFirstCoordinate)]
    public string? YYFirstCoordinate { get; set; }
}