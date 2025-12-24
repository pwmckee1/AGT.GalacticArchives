using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.GameEntities;

public class Fauna : DatabaseGameEntity
{
    public Guid FaunaId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => FaunaId;

    public string? NameAfterExpeditions { get; set; }

    public string? OriginalName { get; set; }

    public FaunaBaitTypes? FaunaBaitType { get; set; }

    public FaunaGenderTypes? Gender1 { get; set; }

    public FaunaGenderTypes? Gender2 { get; set; }

    public FaunaRarityTypes? FaunaRarityType { get; set; }

    public HemisphereTypes? HemisphereType { get; set; }

    public FaunaEcosystemTypes? EcosystemType { get; set; }

    public FaunaBehaviorTypes? BehaviourType { get; set; }

    public FaunaBehaviorArchetypes? BehaviourArchetype { get; set; }

    public FaunaDietTypes? FaunaDietType { get; set; }

    public FaunaDietArchetypes? FaunaDietArchetype { get; set; }

    public FaunaProductionTypes? ProductionType { get; set; }

    public FaunaCircadianTypes? ActivityType { get; set; }

    public float? Gender1ScanMaxWeight { get; set; }

    public float? Gender1ScanMaxHeight { get; set; }

    public float? Gender2ScanMaxWeight { get; set; }

    public float? Gender2ScanMaxHeight { get; set; }

    public float? DiscoveryScreenWeight { get; set; }

    public float? DiscoveryScreenHeight { get; set; }

    public FaunaInGameNoteTypes? FaunaInGameNotes { get; set; }

    public string? FaunaGenusType { get; set; }

    public string? FaunaGenusSubtype { get; set; }

    public string? SummaryNotes { get; set; }

    public string? AppearanceNotes { get; set; }

    public string? DiscoveryMenuNotes { get; set; }

    public string? LocationNotes { get; set; }

    public bool? IsExtinct { get; set; }

    public string? NMSWikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public string? LegacyFaunaNamePC { get; set; }

    public string? LegacyFaunaDiscovererPC { get; set; }

    public DateTimeOffset? LegacyFaunaDatePC { get; set; }

    public string? LegacyFaunaNamePS { get; set; }

    public string? LegacyFaunaDiscovererPS { get; set; }

    public DateTimeOffset? LegacyFaunaDatePS { get; set; }

    public string? LegacyFaunaNameXbox { get; set; }

    public string? LegacyFaunaDiscovererXbox { get; set; }

    public DateTimeOffset? LegacyFaunaDateXbox { get; set; }
}