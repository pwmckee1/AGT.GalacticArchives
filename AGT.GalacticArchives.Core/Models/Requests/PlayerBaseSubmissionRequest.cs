using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.InGame.CombinedTypes;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class PlayerBaseSubmissionRequest : BaseSubmissionRequest
{
    public string PlayerBaseName { get; set; } = null!;

    public PlayerBaseClassificationTypes? Classification { get; set; }

    public string? PlanetGlyph { get; set; }

    public string? NameOfPlayerBaseBuilder { get; set; }

    public PlayerBaseTypes? BaseType { get; set; }

    public bool? HasFarmProduction { get; set; }

    public bool? HasGeobay { get; set; }

    public bool? HasPvpArena { get; set; }

    public bool? HasLandingPad { get; set; }

    public bool? HasRaceTrack { get; set; }

    public bool? HasTradeTerminal { get; set; }

    public LocationTypes NearbyPOITypes { get; set; }

    public DateTime? ConstructionStarted { get; set; }

    public DateTime? ConstructionEnded { get; set; }

    public PlayerBasePowerTypes? PowerConditions { get; set; }

    public PlayerBaseTerrainTypes? TerrainSituation { get; set; }

    /// <summary>
    /// Uses <see cref="HarvestedMaterial"/> to combine Base, Exotic, and other types of material types;
    /// </summary>
    public HashSet<HarvestedMaterial> MineralExtractorContents { get; set; } = [];

    public string? MineralExtractorCapacity { get; set; }

    public HashSet<AtmosphereMaterialTypes> GasExtractorContents { get; set; } = [];

    public string? GasExtractorCapacity { get; set; }

    public HashSet<PlayerBaseElementTypes> PlayerBaseElements { get; set; } = [];
}