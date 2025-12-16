namespace AGT.GalacticArchives.Core.Models.Requests;

public class NaturalWonderSubmissionRequest : BaseSubmissionRequest
{
    public string NaturalWonderName { get; set; } = null!;

    public string ReasonForStatus { get; set; } = null!;

    public string ContactInformation { get; set; } = null!;
}