using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class Starship : DatabaseGameEntity
{
    public Guid StarshipId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => StarshipId;

    public StarshipLocationTypes? Location { get; set; }

    public string? Pilot { get; set; }

    public string? RegionName { get; set; }

    public string? StarSystemName { get; set; }

    public string? PlanetName { get; set; }

    public StarshipModelTypes? StarshipModelType { get; set; }

    public StarshipSubModelTypes? StarshipSubtype { get; set; }

    public StarshipWingTypes? WingType { get; set; }

    public StarshipHullAccessoryTypes? HullAccessories { get; set; }

    public StarshipThrusterTypes? Thruster { get; set; }

    public StarshipExtraHullAccessoryTypes? ExtraHullAccessories { get; set; }

    public ItemClassTypes? Class { get; set; }

    public InventorySizeTypes? InventorySize { get; set; }

    public int? InventorySlots { get; set; }

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