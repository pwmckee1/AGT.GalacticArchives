namespace AGT.GalacticArchives.Core.Models.Requests;

public class SettlementSubmissionRequest : BaseSubmissionRequest
{
    public string SettlementName { get; set; } = null!;
}