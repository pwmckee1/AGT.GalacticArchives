using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class Starship : DatabaseGameEntity
{
    public Guid StarshipId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => StarshipId;

    public LocationTypes? Location { get; set; }

    public string? Pilot { get; set; }

    public StarshipComponents? Type { get; set; }

    public StarshipComponents? ShipSubtype { get; set; }

    public bool? HasWings { get; set; }

    public StarshipComponents? HullAccessories { get; set; }

    public StarshipComponents? Thruster { get; set; }

    public StarshipComponents? MoreHullAccessories { get; set; }

    public ItemClassTypes? Class { get; set; }

    public int? InventorySize { get; set; }

    public int? Slots { get; set; }

    public int? TechSlots { get; set; }

    public int? CargoSlots { get; set; }

    public int? Cost { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public float? Damage { get; set; }

    public float? Shield { get; set; }

    public float? Warp { get; set; }

    public float? Maneuver { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? DescriptionNotes { get; set; }

    public ItemColorTypes? PrimaryColor { get; set; }

    public ItemColorTypes? SecondaryColor { get; set; }

    public ItemColorTypes? AccentColor { get; set; }

    public HashSet<StarshipUpgradeTypes?> UpgradeModules { get; set; } = [];

    public string? ResearchTeam { get; set; }

    public bool? FreighterCostEvaluation { get; set; }
}