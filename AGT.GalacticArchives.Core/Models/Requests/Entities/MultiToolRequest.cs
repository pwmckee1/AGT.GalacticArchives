namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class MultiToolRequest
{
    public Guid? MultiToolId { get; set; }

    public string? Name { get; set; }

    public Guid? StarSystemId { get; set; }

    public StarSystemRequest? StarSystem { get; set; }

    public Guid? PlanetId { get; set; }

    public PlanetRequest? Planet { get; set; }

    public string? Location { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? Type { get; set; }

    public string? Category { get; set; }

    public string? Class { get; set; }

    public int? Slots { get; set; }

    public bool? HasCrystals { get; set; }

    public bool? HasHorns { get; set; }

    public bool? HasGlowTubes { get; set; }

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