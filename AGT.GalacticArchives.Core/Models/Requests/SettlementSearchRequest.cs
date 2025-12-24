namespace AGT.GalacticArchives.Core.Models.Requests;

public class SettlementSearchRequest : GameEntitySearchRequest
{
    public Guid? SettlementId { get; set; }

    public string SettlementName { get; set; } = null!;
}