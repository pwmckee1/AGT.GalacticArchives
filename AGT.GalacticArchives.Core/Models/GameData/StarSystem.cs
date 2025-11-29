using AGT.GalacticArchives.Core.Interfaces.GameData;

namespace AGT.GalacticArchives.Core.Models.GameData;

public class StarSystem : IGameData
{
    public Guid EntityId => StarSystemId;

    public Guid StarSystemId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalSystemName { get; set; }

    public required string GalacticCoordinates { get; set; }

    // TODO Get with Caleb about calculation
    public string? GlyphCode { get; set; }

    public string? PlanetOfInterestId { get; set; }

    public string? SurveyorName { get; set; }

    public string? DiscoveredBy { get; set; }

    public bool IsGiantSystem { get; set; }

    public DateTime? DiscoveryDate { get; set; }

    public DateTime? SurveyDate { get; set; }

    public string? SpecialInterest { get; set; }

    public bool IsDissonant { get; set; }

    public string? CivilizedBy { get; set; }

    public string? PlatformType { get; set; }

    public string? GameModeType { get; set; }

    public int? StarCount { get; set; }

    public string? StarCategory { get; set; }

    public string? Color { get; set; }

    public int? NumberOfPlanets { get; set; }

    public int? NumberOfMoons { get; set; }

    public string? Faction { get; set; }

    public int? LightYearsFromCenter { get; set; }

    public bool HasWater { get; set; }

    public string? EconomyType { get; set; }

    public string? WealthType { get; set; }

    public float? Buy { get; set; }

    public float? Sell { get; set; }

    public string? ConflictType { get; set; }

    public string? GameRelease { get; set; }

    public Guid? RegionId { get; set; }

    public Region? Region { get; set; }

    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(StarSystemId), StarSystemId.ToString() },
            { nameof(Name), Name },
            { nameof(NormalizedName), NormalizedName },
            { nameof(AdminNotes), AdminNotes },
            { nameof(DataQualityCheck), DataQualityCheck },
            { nameof(OriginalSystemName), OriginalSystemName },
            { nameof(GalacticCoordinates), GalacticCoordinates },
            { nameof(GlyphCode), GlyphCode },
            { nameof(PlanetOfInterestId), PlanetOfInterestId.ToString() },
            { nameof(SurveyorName), SurveyorName },
            { nameof(DiscoveredBy), DiscoveredBy },
            { nameof(IsGiantSystem), IsGiantSystem },
            { nameof(SpecialInterest), SpecialInterest },
            { nameof(IsDissonant), IsDissonant },
            { nameof(CivilizedBy), CivilizedBy },
            { nameof(PlatformType), PlatformType },
            { nameof(GameModeType), GameModeType },
            { nameof(StarCount), StarCount },
            { nameof(StarCategory), StarCategory },
            { nameof(Color), Color },
            { nameof(NumberOfPlanets), NumberOfPlanets },
            { nameof(NumberOfMoons), NumberOfMoons },
            { nameof(Faction), Faction },
            { nameof(LightYearsFromCenter), LightYearsFromCenter },
            { nameof(HasWater), HasWater },
            { nameof(EconomyType), EconomyType },
            { nameof(WealthType), WealthType },
            { nameof(Buy), Buy },
            { nameof(Sell), Sell },
            { nameof(ConflictType), ConflictType },
            { nameof(GameRelease), GameRelease },
            { nameof(RegionId), RegionId.ToString() },
        };
    }
}