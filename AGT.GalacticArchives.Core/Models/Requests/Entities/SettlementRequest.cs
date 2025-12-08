namespace AGT.GalacticArchives.Core.Models.Requests.Entities;

public class SettlementRequest
{
    public Guid? SettlementId { get; set; }

    public string? Name { get; set; }

    public Guid? PlanetId { get; set; }

    public PlanetRequest? Planet { get; set; }

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
}