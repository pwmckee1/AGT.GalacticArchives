namespace AGT.GalacticArchives.Core.Models.GameData;

using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

public class PointOfInterest : GameDataEntity
{
    public override Guid EntityId => PointOfInterestId;

    public override Guid ParentId => PlanetId;

    public override string CollectionName => DatabaseConstants.PointOfInterestCollection;

    public override string ParentCollectionName => DatabaseConstants.PlanetCollection;

    public Guid PointOfInterestId = Guid.NewGuid();

    [Display(ResourceType = typeof(PointOfInterestResource), Description = nameof(PointOfInterestResource.Name))]
    public override required string Name { get; set; }

    public required Guid PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameDataEntity? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(PointOfInterest).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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