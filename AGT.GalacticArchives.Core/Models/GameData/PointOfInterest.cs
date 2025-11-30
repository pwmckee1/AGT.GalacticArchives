using AGT.GalacticArchives.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class PointOfInterest : GameData
{
    public override Guid EntityId => PointOfInterestId;

    public Guid PointOfInterestId = Guid.NewGuid();

    [Display(ResourceType = typeof(PointOfInterestResource), Description = nameof(PointOfInterestResource.Name))]
    public override required string Name { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }

    public Guid? StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }
    public override Dictionary<string, object?> ToDictionary(
        GameData gameData = null!,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(PointOfInterest).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        excludedProperties =
        [
            nameof(EntityId),
            nameof(StarSystem),
        ];

        return base.ToDictionary(this, properties, excludedProperties);
    }
}