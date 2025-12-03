using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Models.GameData.BaseEntities;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class PointOfInterest : InnerSystemEntity
{
    public override Guid EntityId => PointOfInterestId;

    public override Guid ParentId => PlanetId!.Value;

    public override string CollectionName => DatabaseConstants.PointOfInterestCollection;

    public override string ParentCollectionName => DatabaseConstants.PlanetCollection;

    public required Guid PointOfInterestId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(PointOfInterestResource), Description = nameof(PointOfInterestResource.Name))]
    public override required string Name { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}