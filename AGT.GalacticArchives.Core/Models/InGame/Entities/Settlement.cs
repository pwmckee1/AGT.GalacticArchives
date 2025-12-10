using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class Settlement : DatabaseGameEntity
{
    public Guid SettlementId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => SettlementId;

    public string? OriginalName { get; set; }

    public EconomyTypes? Economy { get; set; }

    public string? Overseer { get; set; }

    public string? OverseerLink { get; set; }

    public string? Production { get; set; }

    public QualityClassTypes? Class { get; set; }

    public int? Population { get; set; }

    public int? Happiness { get; set; }

    public int? Productivity { get; set; }

    public int? Maintenance { get; set; }

    public int? Sentinel { get; set; }

    public string? Industry { get; set; }

    public bool? IsProfitable { get; set; }

    public HashSet<SettlementBuildingTypes> Buildings { get; set; } = [];
}