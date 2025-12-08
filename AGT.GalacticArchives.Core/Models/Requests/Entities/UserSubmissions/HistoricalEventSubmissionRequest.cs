namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class HistoricalEventSubmissionRequest : BaseSubmissionRequest
{
    public string EventTitle { get; set; } = null!;

    public string NameOfPersonToGiveCredit { get; set; } = null!;

    public string? ContactInformation { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Description { get; set; } = null!;
}