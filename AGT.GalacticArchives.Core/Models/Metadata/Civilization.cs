using AGT.GalacticArchives.Core.Models.Database;

namespace AGT.GalacticArchives.Core.Models.Metadata;

public class Civilization : DatabaseEntity
{
    public Guid CivilizationId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => CivilizationId;

    public string? NoticeTemplate { get; set; }

    public string? FooterTemplate { get; set; }
}