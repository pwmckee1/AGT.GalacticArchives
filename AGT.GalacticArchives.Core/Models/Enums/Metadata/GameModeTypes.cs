using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.Metadata;

public enum GameModeTypes
{
    Normal = 1,

    [Display(
        ResourceType = typeof(GameModeTypeResource),
        Description = nameof(GameModeTypeResource.CommunityExpedition))]
    CommunityExpedition,
    Custom,
    Creative,
    Survival,
    Permadeath,
}