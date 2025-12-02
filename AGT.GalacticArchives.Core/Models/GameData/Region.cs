using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Region : GameData
{
    private string? _coordinates;

    public override Guid EntityId => RegionId;

    public override Guid ParentId => GalaxyId;

    public override string CollectionName => DatabaseConstants.RegionCollection;

    public override string ParentCollectionName => DatabaseConstants.GalaxyCollection;

    public Guid RegionId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(RegionResource), Description = nameof(RegionResource.Name))]
    public override required string Name { get; set; }

    public required Guid GalaxyId { get; set; }

    public string? CivilizedBy { get; set; }


    public string? Coordinates
    {
        get => _coordinates;
        set => _coordinates = value.GetValidatedCoordinates();
    }


    public string? Quadrant { get; set; }

    public string XX => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[0] : string.Empty;

    public string YY => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[1] : string.Empty;

    public string ZZ => !string.IsNullOrEmpty(_coordinates) ? _coordinates.Split(':')[2] : string.Empty;

    public int DocSequence { get; set; }

    public string? GameRelease { get; set; }

    public string? EarliestKnownSurveyor { get; set; }

    public string? LatestKnownSurveyor { get; set; }

    public string? SurveyDate { get; set; }

    public string? SummaryNotes { get; set; }

    public string? LocationNotes { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? CivilizedSpaceNotes { get; set; }

    public float? RegionAge { get; set; }

    public string? LowestKnownPhantomSystem { get; set; }

    public string? WikiLink { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? VideoLink1 { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public string? EarliestSystemDiscovery { get; set; }

    public string? BaseCoord { get; set; }

    public string? EarliestSurveyorWikiUser { get; set; }

    public string? LatestSurveyorWikiUser { get; set; }

    public string? AdminNotes { get; set; }

    public string? LegacyName { get; set; }

    public string? LegacyWikilink { get; set; }

    public float? XXdec { get; set; }

    public float? YYdec { get; set; }

    public float? ZZdec { get; set; }

    public string? Glylphs { get; set; }

    public string? Version { get; set; }

    public HashSet<StarSystem> StarSystems { get; set; } = [];

    public Galaxy? Galaxy { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Region).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(StarSystems),
            nameof(Galaxy),
            nameof(CollectionName),
            nameof(ParentCollectionName),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}