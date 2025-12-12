using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Planet;

public enum FaunaBehaviorArchetypes
{
    Generic = 1,
    Passive,
    [Display(ResourceType = typeof(FaunaBehaviorResource), Description = nameof(FaunaBehaviorResource.PlayerPredator))]
    PlayerPredator,
    Predator,
    Prey,
}