using AGT.GalacticArchives.Core.Enums;
using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class StarSystem : IGameData
{
    public Guid EntityId => StarSystemId;

    public required Guid StarSystemId
    {
        get => field == Guid.Empty ? Guid.NewGuid() : field;
        set;
    }

    public required string Name { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalSystemName { get; set; }

    public required string GalacticCoordinates { get; set; }

    // TODO Get with Caleb about calculation
    public required string GlyphCode { get; set; }

    public Guid? PlanetOfInterestId { get; set; }

    public string? SurveyorName { get; set; }

    public string? DiscoveredBy { get; set; }

    public bool IsGiantSystem { get; set; }

    public string? SpecialInterest { get; set; }

    public bool IsDissonant { get; set; }

    public string? CivilizedBy { get; set; }

    public PlatformTypes? PlatformType { get; set; }

    public GameModeTypes? GameModeType { get; set; }

    public int? StarCount { get; set; }

    public string? StarCategory { get; set; }

    public string? Color { get; set; }

    public int? NumberOfPlanets { get; set; }

    public int? NumberOfMoons { get; set; }

    public FactionTypes? Faction { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public bool HasWater { get; set; }

    public EconomyTypes? EconomyType { get; set; }

    public WealthTypes? WealthType { get; set; }

    public float? Buy { get; set; }

    public float? Sell { get; set; }

    public ConflictTypes? ConflictType { get; set; }

    public string? GameRelease { get; set; }

    public Guid RegionId { get; set; }

    public Region Region { get; set; } = null!;

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(StarSystemId), StarSystemId },
            { nameof(Name), Name },
            { nameof(AdminNotes), AdminNotes },
            { nameof(DataQualityCheck), DataQualityCheck },
            { nameof(OriginalSystemName), OriginalSystemName },
            { nameof(GalacticCoordinates), GalacticCoordinates },
            { nameof(GlyphCode), GlyphCode },
            { nameof(PlanetOfInterestId), PlanetOfInterestId },
            { nameof(SurveyorName), SurveyorName },
            { nameof(DiscoveredBy), DiscoveredBy },
            { nameof(IsGiantSystem), IsGiantSystem },
            { nameof(SpecialInterest), SpecialInterest },
            { nameof(IsDissonant), IsDissonant },
            { nameof(CivilizedBy), CivilizedBy },
            { nameof(PlatformType), PlatformType.ToString() },
            { nameof(GameModeType), GameModeType.ToString() },
            { nameof(StarCount), StarCount },
            { nameof(StarCategory), StarCategory },
            { nameof(Color), Color },
            { nameof(NumberOfPlanets), NumberOfPlanets },
            { nameof(NumberOfMoons), NumberOfMoons },
            { nameof(Faction), Faction.ToString() },
            { nameof(LightYearsFromCenter), LightYearsFromCenter },
            { nameof(HasWater), HasWater },
            { nameof(EconomyType), EconomyType.ToString() },
            { nameof(WealthType), WealthType.ToString() },
            { nameof(Buy), Buy },
            { nameof(Sell), Sell },
            { nameof(ConflictType), ConflictType.ToString() },
            { nameof(GameRelease), GameRelease },
        };
    }
}