using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class PlayerBase : DatabaseGameEntity
{
    public Guid PlayerBaseId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => PlayerBaseId;

    public string? BuilderName { get; set; }

    public PlayerBaseTypes? BaseType { get; set; }

    public bool? HasFarm { get; set; }

    public bool? HasGeobay { get; set; }

    public bool? HasArena { get; set; }

    public bool? HasLandingPad { get; set; }

    public bool? HasRacetrack { get; set; }

    public bool? HasTradeTerminal { get; set; }

    public HashSet<LocationTypes?> NearByPointsOfInterest { get; set; } = [];

    public DateTime? DateStarted { get; set; }

    public DateTime? DateFinished { get; set; }

    public string? SummaryText { get; set; }

    public string? LayoutDescription { get; set; }

    public PlayerBasePowerTypes? PowerSituation { get; set; }

    public PlayerBaseTerrainTypes? AccessOrTerrainSituation { get; set; }

    /// <summary>
    /// Uses reference type <see cref="HarvestedMaterial"/> to combine Base and Exotic materials;
    /// </summary>
    public HashSet<HarvestedMaterialType> MineralExtractorContents { get; set; } = [];

    public int? MineralExtractorCapacity { get; set; }

    public HashSet<AtmosphereMaterialTypes> GasExtractorContents { get; set; } = [];

    public int? GasExtractorCapacity { get; set; }

    public HashSet<PlayerBaseElementTypes> BaseElements { get; set; } = [];

    public int? AestheticsRating { get; set; }

    public int? BaseComplexity { get; set; }

    public string? PersonalNotes { get; set; }

    public PlayerBaseClassificationTypes? BaseClassification { get; set; }

    public string? Videos { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? PortalRepositoryLink { get; set; }

    public bool? AllowsDeconstruction { get; set; }
}