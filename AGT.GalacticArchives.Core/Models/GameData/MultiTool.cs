using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class MultiTool : InnerSystemEntity
{
    public override Guid EntityId => MultiToolId;

    public override Guid ParentId => PlanetId ?? StarSystemId;

    public override string CollectionName => DatabaseConstants.MultiToolCollection;

    public override string ParentCollectionName =>
        PlanetId.HasValue ? DatabaseConstants.PlanetCollection : DatabaseConstants.StarSystemCollection;

    public Guid MultiToolId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(MultiToolResource), Description = nameof(MultiToolResource.Name))]
    public override required string Name { get; set; }

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

    public string? AcquisitionGuidance { get; set; }

    public string? UserNotes { get; set; }

    public string? DocumentSequence { get; set; }

    public string? WikiLink { get; set; }

    public string? ResearchTeam { get; set; }
}