using AGT.GalacticArchives.Core.Constants;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.Imports;

public class StarshipImport : IGoogleSheetImport
{
    [Name(StarshipSheetFields.Name)]
    public string? Name { get; set; }

    [Name(StarshipSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(StarshipSheetFields.Region)]
    public string? Region { get; set; }

    [Name(StarshipSheetFields.System)]
    public string? System { get; set; }

    [Name(StarshipSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(StarshipSheetFields.Location)]
    public string? Location { get; set; }

    [Name(StarshipSheetFields.YYFirstCoordinate)]
    public string? YYFirstCoordinate { get; set; }

    [Name(StarshipSheetFields.XXSecondCoordinate)]
    public string? XXSecondCoordinate { get; set; }

    [Name(StarshipSheetFields.Coordinates)]
    public string? Coordinates { get; set; }

    [Name(StarshipSheetFields.PortalGlyphs)]
    public string? PortalGlyphs { get; set; }

    [Name(StarshipSheetFields.Pilot)]
    public string? Pilot { get; set; }

    [Name(StarshipSheetFields.Type)]
    public string? Type { get; set; }

    [Name(StarshipSheetFields.ShipSubtype)]
    public string? ShipSubtype { get; set; }

    [Name(StarshipSheetFields.HasWings)]
    public string? HasWings { get; set; }

    [Name(StarshipSheetFields.HullAccessories)]
    public string? HullAccessories { get; set; }

    [Name(StarshipSheetFields.Thruster)]
    public string? Thruster { get; set; }

    [Name(StarshipSheetFields.MoreHullAccessories)]
    public string? MoreHullAccessories { get; set; }

    [Name(StarshipSheetFields.Class)]
    public string? Class { get; set; }

    [Name(StarshipSheetFields.InventorySize)]
    public string? InventorySize { get; set; }

    [Name(StarshipSheetFields.Slots)]
    public string? Slots { get; set; }

    [Name(StarshipSheetFields.TechSlots)]
    public string? TechSlots { get; set; }

    [Name(StarshipSheetFields.CargoSlots)]
    public string? CargoSlots { get; set; }

    [Name(StarshipSheetFields.Cost)]
    public string? Cost { get; set; }

    [Name(StarshipSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(StarshipSheetFields.DiscoveredDate)]
    public string? DiscoveredDate { get; set; }

    [Name(StarshipSheetFields.Mode)]
    public string? Mode { get; set; }

    [Name(StarshipSheetFields.Platform)]
    public string? Platform { get; set; }

    [Name(StarshipSheetFields.Release)]
    public string? Release { get; set; }

    [Name(StarshipSheetFields.Damage)]
    public string? Damage { get; set; }

    [Name(StarshipSheetFields.Shield)]
    public string? Shield { get; set; }

    [Name(StarshipSheetFields.Warp)]
    public string? Warp { get; set; }

    [Name(StarshipSheetFields.Maneuver)]
    public string? Maneuver { get; set; }

    [Name(StarshipSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(StarshipSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    [Name(StarshipSheetFields.DescriptionNotes)]
    public string? DescriptionNotes { get; set; }

    [Name(StarshipSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(StarshipSheetFields.PrimaryColor)]
    public string? PrimaryColor { get; set; }

    [Name(StarshipSheetFields.SecondaryColor)]
    public string? SecondaryColor { get; set; }

    [Name(StarshipSheetFields.AccentColor)]
    public string? AccentColor { get; set; }

    [Name(StarshipSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(StarshipSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(StarshipSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(StarshipSheetFields.FreighterCostEvaluation)]
    public string? FreighterCostEvaluation { get; set; }
}