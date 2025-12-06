using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Environments;

public class Galaxy : IGameData
{
    public Guid GalaxyId { get; set; } = Guid.NewGuid();

    public Guid Id => GalaxyId;

    [Display(ResourceType = typeof(PlanetResource), Description = nameof(PlanetResource.Name))]
    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public required int Sequence { get; set; }

    public HashSet<Region> Regions { get; set; } = [];
}