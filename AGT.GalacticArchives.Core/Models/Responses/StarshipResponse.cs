namespace AGT.GalacticArchives.Core.Models.Responses;

public class StarshipResponse : ResponseStarSystemEntity
{
    public Guid? PlanetId { get; set; }

    public PlanetResponse? Planet { get; set; }

    public string? Location { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? Pilot { get; set; }

    public string? Type { get; set; }

    public string? ShipSubtype { get; set; }

    public bool? HasWings { get; set; }

    public string? HullAccessories { get; set; }

    public string? Thruster { get; set; }

    public string? MoreHullAccessories { get; set; }

    public string? Class { get; set; }

    public string? InventorySize { get; set; }

    public int? Slots { get; set; }

    public int? Techslots { get; set; }

    public int? CargoSlots { get; set; }

    public int? Cost { get; set; }

    public string? CivilizedBy { get; set; }

    public string? DiscoveredBy { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public string? DiscoveredDate { get; set; }

    public string? Mode { get; set; }

    public string? Platform { get; set; }

    public string? Release { get; set; }

    public float? Damage { get; set; }

    public float? Shield { get; set; }

    public float? Warp { get; set; }

    public float? Maneuver { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? DescriptionNotes { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? PrimaryColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? AccentColor { get; set; }

    public HashSet<string?> UpgradeModules { get; set; } = [];

    public int? DocumentSequence { get; set; }

    public string? WikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public bool? FreighterCostEvaluation { get; set; }
}