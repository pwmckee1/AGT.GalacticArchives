using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum FaunaBaitTypes
{
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.BloodyOrgan))]
    BloodyOrgan = 1,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.CreaturePellets))]
    CreaturePellets,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.EnzymeFluid))]
    EnzymeFluid,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.FermentedFruit))]
    FermentedFruit,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.GroundMeat))]
    GroundMeat,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.PheromoneSac))]
    PheromoneSac,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.ScentedHerbs))]
    ScentedHerbs,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.SweetenedCompost))]
    SweetenedCompost,
    [Display(ResourceType = typeof(FaunaBaitTypeResource), Description = nameof(FaunaBaitTypeResource.SyntheticWorms))]
    SyntheticWorms,
}