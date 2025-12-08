namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class NaturalWonderSubmissionRequest : BaseSubmissionRequest
{
    public string NaturalWonderName { get; set; } = null!;

    public string StarSystemDiscovererName { get; set; } = null!;

    public string? PlanetDiscovererName { get; set; }

    public string ReasonForStatus { get; set; } = null!;

    public string ContactInformation { get; set; } = null!;

    public HashSet<string> WebLinks { get; set; } = [];
}