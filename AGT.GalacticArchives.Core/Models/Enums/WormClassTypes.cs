using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum WormClassTypes
{
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.CeaselessBurrower))]
    CeaselessBurrower,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.ColossalBeing))]
    ColossalBeing,
    Gargantuan,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.GiantParasite))]
    GiantParasite,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.PlanetaryMaggot))]
    PlanetaryMaggot,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.TheConsumer))]
    TheConsumer,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.UnstoppableNematode))]
    UnstoppableNematode,
    [Display(ResourceType = typeof(FaunaResource), Description = nameof(FaunaResource.WormLord))]
    WormLord,
}