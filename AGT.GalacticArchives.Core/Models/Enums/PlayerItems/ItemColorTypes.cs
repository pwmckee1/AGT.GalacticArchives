using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public enum ItemColorTypes
{
    Aqua = 1,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.AquaGreen))]
    AquaGreen,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.ArcticWhite))]
    ArcticWhite,
    Azure,
    Beige,
    Black,
    Blue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.BlueGreen))]
    BlueGreen,
    Bronze,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.BronzeYellow))]
    BronzeYellow,
    Brown,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.BubbleGum))]
    BubbleGum,
    Burgundy,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.BurntOrange))]
    BurntOrange,
    Cerulean,
    Chartreuse,
    Chrome,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.CobaltBlue))]
    CobaltBlue,
    Cocoa,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.CoolGrey))]
    CoolGrey,
    Copper,
    Coral,
    Cream,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.CrimsonRed))]
    CrimsonRed,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.CurryYellow))]
    CurryYellow,
    Cyan,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.DarkBrown))]
    DarkBrown,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.DarkMagenta))]
    DarkMagenta,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.DarkOrange))]
    DarkOrange,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.DarkPurple))]
    DarkPurple,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.DustyPink))]
    DustyPink,
    Ebony,
    Eggshell,
    Emerald,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.ForestGreen))]
    ForestGreen,
    Fuchsia,
    Gold,
    Goldenrod,
    Grape,
    Green,
    Grey,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.GunmetalBlue))]
    GunmetalBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.GunmetalGrey))]
    GunmetalGrey,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.HarvestGold))]
    HarvestGold,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.HotPink))]
    HotPink,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.HunterGreen))]
    HunterGreen,
    Indigo,
    Ivory,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.JadeGreen))]
    JadeGreen,
    Khaki,
    Lavender,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LemonYellow))]
    LemonYellow,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LightBlue))]
    LightBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LightBrown))]
    LightBrown,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LightGreen))]
    LightGreen,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LightOrange))]
    LightOrange,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LightYellow))]
    LightYellow,
    Lilac,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.LimeGreen))]
    LimeGreen,
    Magneta,
    Mahogany,
    Mango,
    Maroon,
    Mauve,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.MetallicBlue))]
    MetallicBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.MetallicBronze))]
    MetallicBronze,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.MetallicCopper))]
    MetallicCopper,
    Mint,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.MochaBrown))]
    MochaBrown,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.MossGreen))]
    MossGreen,
    Mustard,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.NavyBlue))]
    NavyBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.NeonGreen))]
    NeonGreen,
    Obsidian,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.OcherBrown))]
    OcherBrown,
    Olive,
    Orange,
    Orchid,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.CurryYellow))]
    PaleRose,
    Paprika,
    Peach,
    Pearl,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.PineGreen))]
    PineGreen,
    Pink,
    Platinum,
    Plum,
    Purple,
    Raspberry,
    Red,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.RedOrange))]
    RedOrange,
    Rose,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.RoseGold))]
    RoseGold,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.RoyalBlue))]
    RoyalBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.RubyRed))]
    RubyRed,
    Rust,
    Salmon,
    Sand,
    Sapphire,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.ScarletRed))]
    ScarletRed,
    Silver,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.SkyBlue))]
    SkyBlue,
    Slate,
    Steel,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.StoneGreen))]
    StoneGreen,
    Tan,
    Tangerine,
    Taupe,
    Teal,
    Terracotta,
    Turquoise,
    Vermillion,
    Violet,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.VistaBlue))]
    VistaBlue,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.WarmGrey))]
    WarmGrey,
    White,
    Yellow,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.YellowGreen))]
    YellowGreen,

    [Display(ResourceType = typeof(ItemColorTypeResource), Description = nameof(ItemColorTypeResource.YellowOrange))]
    YellowOrange,
}