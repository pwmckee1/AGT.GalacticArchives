using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class StarshipImport : IGoogleSheetImport
{
    [Name(StarshipSheetFields.StarshipName)]
    public string? StarshipName { get; set; }

    [Name(StarshipSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(StarshipSheetFields.Region)]
    public string? Region { get; set; }

    [Name(StarshipSheetFields.StarSystem)]
    public string? StarSystem { get; set; }

    [Name(StarshipSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(StarshipSheetFields.Location)]
    public StarshipLocationTypes? Location { get; set; }

    [Name(StarshipSheetFields.YYFirstCoordinate)]
    public float? YYFirstCoordinate { get; set; }

    [Name(StarshipSheetFields.XXSecondCoordinate)]
    public float? XXSecondCoordinate { get; set; }

    [Name(StarshipSheetFields.Coordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(StarshipSheetFields.PortalGlyphs)]
    public string? PortalGlyphs { get; set; }

    [Name(StarshipSheetFields.Pilot)]
    public string? Pilot { get; set; }

    [Name(StarshipSheetFields.StarshipModelType)]
    public StarshipModelTypes? StarshipModelType { get; set; }

    [Name(StarshipSheetFields.Subtype)]
    public StarshipSubModelTypes? Subtype { get; set; }

    [Name(StarshipSheetFields.WingType)]
    public StarshipWingTypes? WingType { get; set; }

    [Name(StarshipSheetFields.HullAccessories)]
    public StarshipHullAccessoryTypes? HullAccessories { get; set; }

    [Name(StarshipSheetFields.Thruster)]
    public StarshipThrusterTypes? Thruster { get; set; }

    [Name(StarshipSheetFields.ExtraHullAccessories)]
    public StarshipExtraHullAccessoryTypes? ExtraHullAccessories { get; set; }

    [Name(StarshipSheetFields.Class)]
    public ItemClassTypes? Class { get; set; }

    [Name(StarshipSheetFields.InventorySize)]
    public InventorySizeTypes? InventorySize { get; set; }

    [Name(StarshipSheetFields.InventorySlots)]
    public int? InventorySlots { get; set; }

    [Name(StarshipSheetFields.TechSlots)]
    public int? TechSlots { get; set; }

    [Name(StarshipSheetFields.CargoSlots)]
    public int? CargoSlots { get; set; }

    [Name(StarshipSheetFields.Cost)]
    public int? Cost { get; set; }

    [Name(StarshipSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(StarshipSheetFields.DiscoveredDate)]
    public DateTime? DiscoveredDate { get; set; }

    [Name(StarshipSheetFields.GameMode)]
    public GameModeTypes? GameMode { get; set; }

    [Name(StarshipSheetFields.GamePlatform)]
    public GamePlatformTypes? GamePlatform { get; set; }

    [Name(StarshipSheetFields.Release)]
    public string? Release { get; set; }

    [Name(StarshipSheetFields.Damage)]
    public float? Damage { get; set; }

    [Name(StarshipSheetFields.Shield)]
    public float? Shield { get; set; }

    [Name(StarshipSheetFields.Warp)]
    public float? Warp { get; set; }

    [Name(StarshipSheetFields.Maneuver)]
    public float? Maneuver { get; set; }

    [Name(StarshipSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(StarshipSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    [Name(StarshipSheetFields.DescriptionNotes)]
    public string? DescriptionNotes { get; set; }

    [Name(StarshipSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(StarshipSheetFields.PrimaryColor)]
    public ItemColorTypes? PrimaryColor { get; set; }

    [Name(StarshipSheetFields.SecondaryColor)]
    public ItemColorTypes? SecondaryColor { get; set; }

    [Name(StarshipSheetFields.AccentColor)]
    public ItemColorTypes? AccentColor { get; set; }

    [Name(StarshipSheetFields.StarshipUpgradeModules)]
    public HashSet<StarshipUpgradeModuleTypes> StarshipUpgradeModules { get; set; } = [];

    [Name(StarshipSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(StarshipSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(StarshipSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }
}