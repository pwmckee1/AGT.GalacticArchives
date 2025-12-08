namespace AGT.GalacticArchives.Core.Models.Requests.Entities.UserSubmissions;

public class SettlementSubmissionRequest : BaseSubmissionRequest
{
    public string SettlementName { get; set; } = null!;
}