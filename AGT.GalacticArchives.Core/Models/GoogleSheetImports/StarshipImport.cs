using AGT.GalacticArchives.Core.Constants.ImportFields;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Enums.Metadata;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Models.GoogleSheetImports;

public class StarshipImport : IImportFormFile
{
    [Name(StarshipSheetFields.StarshipName)]
    public string? StarshipName { get; set; }

    [Name(StarshipSheetFields.Galaxy)]
    public GalaxyTypes? Galaxy { get; set; }

    [Name(StarshipSheetFields.RegionName)]
    public string? RegionName { get; set; }

    [Name(StarshipSheetFields.StarSystemName)]
    public string? StarSystemName { get; set; }

    [Name(StarshipSheetFields.PlanetName)]
    public string? PlanetName { get; set; }

    [Name(StarshipSheetFields.Location)]
    public StarshipLocationTypes? Location { get; set; }

    [Name(StarshipSheetFields.YAxisPlanetCoordinate)]
    public float? YAxisPlanetCoordinate { get; set; }

    [Name(StarshipSheetFields.XAxisPlanetCoordinate)]
    public float? XAxisPlanetCoordinate { get; set; }

    [Name(StarshipSheetFields.Coordinates)]
    public string? GalacticCoordinates { get; set; }

    [Name(StarshipSheetFields.GlyphHexCode)]
    public string? GlyphHexCode { get; set; }

    [Name(StarshipSheetFields.Pilot)]
    public string? Pilot { get; set; }

    [Name(StarshipSheetFields.StarshipModelType)]
    public StarshipModelTypes? StarshipModelType { get; set; }

    [Name(StarshipSheetFields.StarshipSubtype)]
    public StarshipSubModelTypes? StarshipSubtype { get; set; }

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

    [Name(StarshipSheetFields.Civilization)]
    public string? Civilization { get; set; }

    [Name(StarshipSheetFields.DiscoveredBy)]
    public string? DiscoveredBy { get; set; }

    [Name(StarshipSheetFields.DiscoveredLinkOnWiki)]
    public string? DiscoveredLinkOnWiki { get; set; }

    [Name(StarshipSheetFields.DiscoveryDate)]
    public DateTime? DiscoveryDate { get; set; }

    [Name(StarshipSheetFields.GameModeType)]
    public GameModeTypes? GameModeType { get; set; }

    [Name(StarshipSheetFields.Platform)]
    public GamePlatformTypes? Platform { get; set; }

    [Name(StarshipSheetFields.GameRelease)]
    public string? GameRelease { get; set; }

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

    [Name(StarshipSheetFields.UpgradeModules)]
    public HashSet<StarshipUpgradeModuleTypes> UpgradeModules { get; set; } = [];

    [Name(StarshipSheetFields.DocumentSequence)]
    public string? DocumentSequence { get; set; }

    [Name(StarshipSheetFields.WikiLink)]
    public string? WikiLink { get; set; }

    [Name(StarshipSheetFields.ResearchTeam)]
    public string? ResearchTeam { get; set; }
}