using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.InGame.CombinedTypes;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Globalization;

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

    public QualityClassTypes? Class { get; set; }

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

    public EntityColorTypes? PrimaryColor { get; set; }

    public EntityColorTypes? SecondaryColor { get; set; }

    public EntityColorTypes? AccentColor { get; set; }

    public HashSet<StarshipUpgradeTypes?> UpgradeModules { get; set; } = [];

    public string? WikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public bool? FreighterCostEvaluation { get; set; }
}