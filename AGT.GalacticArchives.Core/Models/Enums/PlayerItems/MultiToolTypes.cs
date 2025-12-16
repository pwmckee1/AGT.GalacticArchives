using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum MultiToolTypes
{
    Pistol = 1,
    Rifle,
    Experimental,
    Alien,
    Royal,
    Sentinel,
    Atlantid,

    [Display(ResourceType = typeof(MultiToolResource), Description = nameof(MultiToolResource.VoltaicStaff))]
    VoltaicStaff,
}