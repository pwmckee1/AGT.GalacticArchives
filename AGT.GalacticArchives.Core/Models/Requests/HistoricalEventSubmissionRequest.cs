namespace AGT.GalacticArchives.Core.Models.Requests;

public class HistoricalEventSubmissionRequest : BaseSubmissionRequest
{
    public string EventTitle { get; set; } = null!;

    public string NameOfPersonToGiveCredit { get; set; } = null!;

    public string? ContactInformation { get; set; }

    public DateTimeOffset? StartDate { get; set; }

    public DateTimeOffset? EndDate { get; set; }

    public string Description { get; set; } = null!;
}