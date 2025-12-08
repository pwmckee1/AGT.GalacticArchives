namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class HeritageSiteSubmissionRequest : BaseSubmissionRequest
{
    public string? ReasonForStatus { get; set; }

    public string? ContactInformation { get; set; }
}