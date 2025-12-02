using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Starship : GameData
{
    public override Guid EntityId => StarshipId;

    public override Guid ParentId => PlanetId ?? StarSystemId;

    public override string CollectionName => DatabaseConstants.StarshipCollection;

    public override string ParentCollectionName =>
        PlanetId.HasValue ? DatabaseConstants.PlanetCollection : DatabaseConstants.StarSystemCollection;

    public Guid StarshipId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(StarshipResource), Description = nameof(StarshipResource.Name))]
    public override required string Name { get; set; }

    public required Guid StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

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

    public override Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Starship).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(StarSystem),
            nameof(Planet),
            nameof(CollectionName),
            nameof(ParentCollectionName),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}