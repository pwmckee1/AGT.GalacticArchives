using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class StarshipImport : IGoogleSheetImport
{
    [Name(StarshipSheetFields.AccentColor)]
    public string? AccentColor { get; set; }

    [Name(StarshipSheetFields.AdditionalNotes)]
    public string? AdditionalNotes { get; set; }

    [Name(StarshipSheetFields.CargoSlots)]
    public string? CargoSlots { get; set; }

    [Name(StarshipSheetFields.Class)]
    public QualityClassTypes Class { get; set; }

    [Name(StarshipSheetFields.CivilizedBy)]
    public string? CivilizedBy { get; set; }

    [Name(StarshipSheetFields.Coordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(StarshipSheetFields.Cost)]
    public string? Cost { get; set; }

    [Name(StarshipSheetFields.Damage)]
    public float Damage { get; set; }

    [Name(StarshipSheetFields.DescriptionNotes)]
    public string? DescriptionNotes { get; set; }

    [Name(StarshipSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredDate)]
    public string? DiscoveredDate { get; set; }

    [Name(StarshipSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(StarshipSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(StarshipSheetFields.FreighterCostEvaluation)]
    public string? FreighterCostEvaluation { get; set; }

    [Name(StarshipSheetFields.Galaxy)]
    public string? Galaxy { get; set; }

    [Name(StarshipSheetFields.HasWings)]
    public string? HasWings { get; set; }

    [Name(StarshipSheetFields.HullAccessories)]
    public StarshipHullAccessoryTypes? HullAccessories { get; set; }

    [Name(StarshipSheetFields.InventorySize)]
    public InventorySizeTypes? InventorySize { get; set; }

    [Name(StarshipSheetFields.Location)]
    public string? Location { get; set; }

    [Name(StarshipSheetFields.LocationNotes)]
    public string? LocationNotes { get; set; }

    [Name(StarshipSheetFields.Maneuver)]
    public float? Maneuver { get; set; }

    [Name(StarshipSheetFields.GameMode)]
    public GameModeTypes GameMode { get; set; }

    [Name(StarshipSheetFields.ExtraHullAccessories)]
    public StarshipExtraHullAccessoryTypes? ExtraHullAccessories { get; set; }

    [Name(StarshipSheetFields.Name)]
    public string Name { get; set; } = null!;

    [Name(StarshipSheetFields.Pilot)]
    public string? Pilot { get; set; }

    [Name(StarshipSheetFields.Planet)]
    public string? Planet { get; set; }

    [Name(StarshipSheetFields.GamePlatform)]
    public GamePlatformType GamePlatformType { get; set; }

    [Name(StarshipSheetFields.PortalGlyphs)]
    public string? PortalGlyphs { get; set; }

    [Name(StarshipSheetFields.PrimaryColor)]
    public string? PrimaryColor { get; set; }

    [Name(StarshipSheetFields.Region)]
    public string? Region { get; set; }

    [Name(StarshipSheetFields.Release)]
    public string? Release { get; set; }

    [Name(StarshipSheetFields.ReleaseDate)]
    public string? ReleaseDate { get; set; }

    [Name(StarshipSheetFields.ReleaseNumber)]
    public string? ReleaseNumber { get; set; }

    [Name(StarshipSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }

    [Name(StarshipSheetFields.SecondaryColor)]
    public string? SecondaryColor { get; set; }

    [Name(StarshipSheetFields.Shield)]
    public float? Shield { get; set; }

    [Name(StarshipSheetFields.Subtype)]
    public StarshipSubModelTypes? SubType { get; set; }

    [Name(StarshipSheetFields.WingType)]
    public StarshipWingTypes? WingType { get; set; }

    [Name(StarshipSheetFields.Slots)]
    public string? Slots { get; set; }

    [Name(StarshipSheetFields.SummaryNotes)]
    public string? SummaryNotes { get; set; }

    [Name(StarshipSheetFields.System)]
    public string? System { get; set; }

    [Name(StarshipSheetFields.TechSlots)]
    public string? TechSlots { get; set; }

    [Name(StarshipSheetFields.Thruster)]
    public StarshipThrusterTypes? Thruster { get; set; }

    [Name(StarshipSheetFields.ModelType)]
    public StarshipModelTypes ModelType { get; set; }

    [Name(StarshipSheetFields.UpgradeModules)]
    public HashSet<StarshipUpgradeModuleTypes> StarshipUpgradeModules { get; set; } = [];

    [Name(StarshipSheetFields.Warp)]
    public float? Warp { get; set; }

    [Name(StarshipSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(StarshipSheetFields.XXSecondCoordinate)]
    public float? XXSecondCoordinate { get; set; }

    [Name(StarshipSheetFields.YYFirstCoordinate)]
    public float? YYFirstCoordinate { get; set; }
}