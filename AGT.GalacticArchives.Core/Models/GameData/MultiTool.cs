using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class MultiTool : GameData
{
    public override Guid EntityId => MultiToolId;

    public override Guid ParentId => PlanetId ?? StarSystemId;

    public override string CollectionName => DatabaseConstants.MultiToolCollection;

    public override string ParentCollectionName =>
        PlanetId.HasValue ? DatabaseConstants.PlanetCollection : DatabaseConstants.StarSystemCollection;

    public Guid MultiToolId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(MultiToolResource), Description = nameof(MultiToolResource.Name))]
    public override required string Name { get; set; }

    public required Guid StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? Location { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? Type { get; set; }

    public string? Category { get; set; }

    public string? Class { get; set; }

    public int? Slots { get; set; }

    public bool? HasCrystals { get; set; }

    public bool? HasHorns { get; set; }

    public bool? HasGlowtubes { get; set; }

    public int? Cost { get; set; }

    public string? CivilizedBy { get; set; }

    public string? DiscoveredBy { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public string? DiscoveryDate { get; set; }

    public string? Platform { get; set; }

    public string? Mode { get; set; }

    public string? Release { get; set; }

    public float? Damage { get; set; }

    public int? Mining { get; set; }

    public float? Scanner { get; set; }

    public string? PrimaryColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? AcquistionGuidance { get; set; }

    public string? UserNotes { get; set; }

    public string? DocumentSequence { get; set; }

    public string? WikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(MultiTool).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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