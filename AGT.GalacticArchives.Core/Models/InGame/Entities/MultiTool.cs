using AGT.GalacticArchives.Core.Models.Database;
using AGT.GalacticArchives.Core.Models.Enums.Planet;
using AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;

public class MultiTool : DatabaseGameEntity
{
    public Guid MultiToolId { get; set; } = Guid.NewGuid();

    public override Guid EntityId => MultiToolId;

    public LocationTypes? Location { get; set; }

    public MultiToolTypes? MultiToolType { get; set; }

    public MultiToolCategoryTypes? MultiToolCategory { get; set; }

    public ItemClassTypes? ItemClass { get; set; }

    public int? TechSlots { get; set; }

    public bool? HasCrystals { get; set; }

    public bool? HasHorns { get; set; }

    public bool? HasGlowTubes { get; set; }

    public int? Cost { get; set; }

    public float? Damage { get; set; }

    public float? Mining { get; set; }

    public float? Scanner { get; set; }

    public ItemColorTypes? PrimaryColor { get; set; }

    public ItemColorTypes? SecondaryColor { get; set; }

    public string? AcquisitionGuidance { get; set; }

    public string? ResearchTeam { get; set; }

    public string? UserNotes { get; set; }
}