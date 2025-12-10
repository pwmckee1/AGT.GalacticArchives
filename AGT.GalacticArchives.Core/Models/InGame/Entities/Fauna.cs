using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Core.Models.InGame.Locations;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class Fauna : DatabaseGameEntity
{
    public Guid FaunaId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => FaunaId;

    public string? NameAfterExpeditions { get; set; }

    public string? OriginalName { get; set; }

    public FaunaBaitTypes? Bait { get; set; }

    public FaunaGenderTypes? Gender1 { get; set; }

    public FaunaGenderTypes? Gender2 { get; set; }

    public FaunaRarityTypes? Rarity { get; set; }

    public string? Hemisphere { get; set; }

    public FaunaEcosystemTypes? Ecosystem { get; set; }

    public FaunaBehaviorTypes? Behaviour { get; set; }

    public FaunaBehaviorArchetypes? BehaviourArchetype { get; set; }

    public FaunaDietTypes? Diet { get; set; }

    public FaunaDietArchetypes? DietArchetype { get; set; }

    public FaunaProductionTypes? Produces { get; set; }

    public FaunaCircadianTypes? Activity { get; set; }

    public float? Gender1ScanMaxWeight { get; set; }

    public float? Gender1ScanMaxHeight { get; set; }

    public float? Gender2ScanMaxWeight { get; set; }

    public float? Gender2ScanMaxHeight { get; set; }

    public float? DiscoveryScreenWeight { get; set; }

    public float? DiscoveryScreenHeight { get; set; }

    public FaunaInGameNoteTypes? Notes { get; set; }

    public FaunaGenusSubtypes? Genus { get; set; }

    public FaunaGenusTypes? GenusSubtype { get; set; }

    public string? SummaryNotes { get; set; }

    public string? Appearance { get; set; }

    public string? DiscoveryMenu { get; set; }

    public string? LocationNotes { get; set; }

    public bool? IsExtinct { get; set; }

    public string? NMSWikiLink { get; set; }

    public string? ResearchTeam { get; set; }

    public string? LegacyFaunaNamePC { get; set; }

    public string? LegacyFaunaDiscovererPC { get; set; }

    public string? LegacyFaunaDatePC { get; set; }

    public string? LegacyFaunaNamePS { get; set; }

    public string? LegacyFaunaDiscovererPS { get; set; }

    public string? LegacyFaunaDatePS { get; set; }

    public string? LegacyFaunaNameXbox { get; set; }

    public string? LegacyFaunaDiscovererXbox { get; set; }

    public string? LegacyFaunaDateXbox { get; set; }
}