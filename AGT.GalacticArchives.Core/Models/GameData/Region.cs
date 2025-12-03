using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Region : DatabaseEntity
{
    public override Guid EntityId => RegionId;

    public override Guid ParentId => GalaxyId;

    public override string CollectionName => DatabaseConstants.RegionCollection;

    public override string ParentCollectionName => DatabaseConstants.GalaxyCollection;

    public Guid RegionId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(RegionResource), Description = nameof(RegionResource.Name))]
    public override required string Name { get; set; }

    public required Guid GalaxyId { get; set; }

    public Galaxy? Galaxy { get; set; }

    public HashSet<StarSystem> StarSystems { get; set; } = [];

    public string? CivilizedBy { get; set; }

    public string? Coordinates
    {
        get;
        set => field = value.GetValidatedCoordinates();
    }

    public string? Quadrant { get; set; }

    public string XX => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[0] : string.Empty;

    public string YY => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[1] : string.Empty;

    public string ZZ => !string.IsNullOrEmpty(Coordinates) ? Coordinates.Split(':')[2] : string.Empty;

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

    public string? Glyphs { get; set; }

    public string? Version { get; set; }
}