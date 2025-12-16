using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;
using AGT.GalacticArchives.Core.Models.Enums.StarSystem;

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

    public ItemClassTypes? Class { get; set; }

    public int? Population { get; set; }

    public int? Happiness { get; set; }

    public int? Productivity { get; set; }

    public int? Maintenance { get; set; }

    public int? Sentinels { get; set; }

    public string? Industry { get; set; }

    public bool? IsProfitable { get; set; }

    public HashSet<SettlementBuildingTypes> Buildings { get; set; } = [];
}