using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class StarshipSubmissionRequest
{
    public string Username { get; set; } = null!;

    public GamePlatformType PlatformType { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public GameRelease GameRelease { get; set; } = new();

    public Galaxies Galaxy { get; set; }

    public string RegionName { get; set; } = null!;

    public string StarSystemName { get; set; } = null!;

    public Communities? CivilizationClaim { get; set; }

    public string GalacticCoordinates { get; set; } = null!;

    public StarshipLocationTypes Location { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public string StarshipName { get; set; } = null!;

    public string? PilotName { get; set; }

    public StarshipModelTypes? Model { get; set; }

    public StarshipSubtypes? LivingShipSubtype { get; set; }

    public StarshipThrusterTypes? LivingShipThrusterType { get; set; }

    public ItemClassTypes Class { get; set; }

    public int? InventorySlots { get; set; }

    public int? TechSlots { get; set; }

    public string DiscoveredBy { get; set; } = null!;

    public DateTime DiscoveryDate { get; set; }

    public float? Damage { get; set; }

    public float? Shield { get; set; }

    public float? Warp { get; set; }

    public float? Maneuver { get; set; }

    public EntityColorTypes? PrimaryColor { get; set; }

    public EntityColorTypes? SecondaryColor { get; set; }

    public EntityColorTypes? AccentColor { get; set; }

    public string? AdditionalNotes { get; set; }
}