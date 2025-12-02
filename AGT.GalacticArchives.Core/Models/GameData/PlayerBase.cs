using AGT.GalacticArchives.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class PlayerBase : GameData
{
    public override Guid EntityId => PlayerBaseId;

    public override Guid ParentId => PlanetId;

    public override string CollectionName => DatabaseConstants.PlayerBaseCollection;

    public override string ParentCollectionName => DatabaseConstants.PlanetCollection;

    public Guid PlayerBaseId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(PlayerBaseResource), Description = nameof(PlayerBaseResource.Name))]
    public override required string Name { get; set; }

    public required Guid PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? CivilizedBy { get; set; }

    public string? Builder { get; set; }

    public string? BuilderLinkOnWiki { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? Platform { get; set; }

    public string? Mode { get; set; }

    public string? Release { get; set; }

    public string? TypeOfBase { get; set; }

    public bool? HasFarm { get; set; }

    public bool? HasGeobay { get; set; }

    public bool? HasArena { get; set; }

    public bool? HasLandingPad { get; set; }

    public bool? HasRacetrack { get; set; }

    public bool? HasTradeTerminal { get; set; }

    public HashSet<string?> NearByPOIs { get; set; } = [];

    public string? DateStarted { get; set; }

    public string? DateFinished { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? SummaryText { get; set; }

    public string? LayoutDescription { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? PowerSituation { get; set; }

    public string? AccessOrTerrainSituation { get; set; }

    public string? MiningExtractor { get; set; }

    public string? MiningStoreCapacity { get; set; }

    public string? GasExtractor { get; set; }

    public string? GasStoreCapacity { get; set; }

    public HashSet<string> BaseElements { get; set; } = [];

    public string? Aesthetics { get; set; }

    public string? BaseComplexity { get; set; }

    public string? PersonalNotes { get; set; }

    public string? BaseType { get; set; }

    public string? WikiLink { get; set; }

    public int? DocSequence { get; set; }

    public string? Videos { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? PortalRepositoryLink { get; set; }

    public bool? AllowsDeconstruction { get; set; }

    public string? ReleaseVersion { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(PlayerBase).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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