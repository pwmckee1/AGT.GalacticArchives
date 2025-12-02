namespace AGT.GalacticArchives.Core.Models.Requests;

public abstract class GameDataRequest
{
    public virtual Guid? ParentId { get; set; }
}