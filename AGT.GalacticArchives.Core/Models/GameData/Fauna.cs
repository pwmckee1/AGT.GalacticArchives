namespace AGT.GalacticArchives.Core.Models.GameData;

using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

public class Fauna : GameDataEntity
{
    public override Guid EntityId => FaunaId;

    public override Guid ParentId => PlanetId;

    public override string CollectionName => DatabaseConstants.FaunaCollection;

    public override string ParentCollectionName => DatabaseConstants.PlanetCollection;

    public Guid FaunaId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.Name))]
    public override required string Name { get; set; }

    public required Guid PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? NameAfterExpeditions { get; set; }

    public string? OriginalName { get; set; }

    public string? Bait { get; set; }

    public string? Gender1 { get; set; }

    public string? Gender2 { get; set; }

    public string? Rarity { get; set; }

    public string? Hemisphere { get; set; }

    public string? Ecosystem { get; set; }

    public string? Behaviour { get; set; }

    public string? BehaviourType { get; set; }

    public string? Diet { get; set; }

    public string? DietType { get; set; }

    public string? Produces { get; set; }

    public string? Activity { get; set; }

    public float? Gender1ScanMaxWeight { get; set; }

    public float? Gender1ScanMaxHeight { get; set; }

    public float? Gender2ScanMaxWeight { get; set; }

    public float? Gender2ScanMaxHeight { get; set; }

    public string? DiscoveryScreenWeight { get; set; }

    public string? DiscoveryScreenHeight { get; set; }

    public string? Notes { get; set; }

    public string? Genus { get; set; }

    public string? GenusSubtype { get; set; }

    public string? CivilizedBy { get; set; }

    public string? DiscoveredBy { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public string? DiscoveredDate { get; set; }

    public string? DiscoveryPlatform { get; set; }

    public string? Mode { get; set; }

    public string? Release { get; set; }

    public string? SummaryNotes { get; set; }

    public string? Appearance { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? DiscoveryMenu { get; set; }

    public string? LocationNotes { get; set; }

    public string? ExtinctionStatus { get; set; }

    public string? NMSWikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public string? LegacyFaunaNamePC { get; set; }

    public string? LegacyFaunaDiscovererPC { get; set; }

    public string? LegacyFaunaDatePC { get; set; }

    public string? LegacyFaunaNamePS { get; set; }

    public string? LegacyFaunaDiscovererPS { get; set; }

    public string? LegacyFaunaDatePS { get; set; }

    public string? LegacyFaunaNameXbox { get; set; }

    public string? LegacyFaunaDiscovererXbox { get; set; }

    public string? LegacyFaunaDateXbox { get; set; }

    public float? VersionRelease { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameDataEntity? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Fauna).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(Planet),
            nameof(CollectionName),
            nameof(ParentCollectionName),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}