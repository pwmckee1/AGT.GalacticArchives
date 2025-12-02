using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class Settlement : GameData
{
    public override Guid EntityId => SettlementId;

    public override Guid ParentId => PlanetId;

    public override string CollectionName => DatabaseConstants.SettlementCollection;

    public override string ParentCollectionName => DatabaseConstants.PlanetCollection;

    public Guid SettlementId { get; set; } = Guid.NewGuid();

    [Display(ResourceType = typeof(SettlementResource), Description = nameof(SettlementResource.Name))]
    public override required string Name { get; set; }

    public required Guid PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? OriginalName { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? Surveyor { get; set; }

    public string? DateObserved { get; set; }

    public string? Economy { get; set; }

    public string? Overseer { get; set; }

    public string? OverseerLink { get; set; }

    public string? Production { get; set; }

    public string? Class { get; set; }

    public string? Population { get; set; }

    public string? Happiness { get; set; }

    public string? Productivity { get; set; }

    public string? Maintenance { get; set; }

    public string? Sentinel { get; set; }

    public string? Industry { get; set; }

    public string? Profitable { get; set; }

    public string? Civilized { get; set; }

    public HashSet<string> Buildings { get; set; } = [];

    public string? Mode { get; set; }

    public string? GameRelease { get; set; }

    public string? WikiLink { get; set; }

    public override Dictionary<string, object?> ToDictionary(
        GameData? gameData = null,
        PropertyInfo[] properties = null!,
        HashSet<string> excludedProperties = null!)
    {
        properties = typeof(Settlement).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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