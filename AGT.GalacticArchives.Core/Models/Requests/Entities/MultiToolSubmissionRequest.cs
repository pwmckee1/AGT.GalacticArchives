using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.Meta;

namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class MultiToolSubmissionRequest
{
    public string Username { get; set; } = null!;

    public string MultiToolName { get; set; } = null!;

    public Galaxies Galaxy { get; set; }

    public string RegionName { get; set; } = null!;

    public string StarSystemName { get; set; } = null!;

    public string GalacticCoordinates { get; set; } = null!;

    public MultiToolLocationTypes Location { get; set; }

    public string? PlanetName { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }

    public MultiToolTypes MultiToolType { get; set; }

    public ItemClassTypes Class { get; set; }

    // Between 8 and 60
    public int InventorySlots { get; set; }

    public string? Cost { get; set; }

    public bool? HasCrystals { get; set; }

    public bool? HasGlowtubes { get; set; }

    public float? Damage { get; set; }

    public float? Mining { get; set; }

    public float? Scanner { get; set; }

    public EntityColorTypes PrimaryColor { get; set; }

    public EntityColorTypes SecondaryColor { get; set; }

    public string GamerTagHandle { get; set; } = null!;

    public DateTime DiscoveryDate { get; set; }

    public GameModeTypes? GameMode { get; set; }

    public GameRelease GameRelease { get; set; } = new();

    public Communities? CivilizationClaim { get; set; }

    public string? AdditionalNotes { get; set; }
}