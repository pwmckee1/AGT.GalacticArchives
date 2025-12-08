using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum EntityColorTypes
{
    Aqua = 1,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.AquaGreen))]
    AquaGreen,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.ArcticWhite))]
    ArcticWhite,
    Azure,
    Beige,
    Black,
    Blue,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.BlueGreen))]
    BlueGreen,
    Bronze,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.BronzeYellow))]
    BronzeYellow,
    Brown,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.BubbleGum))]
    BubbleGum,
    Burgundy,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.BurntOrange))]
    BurntOrange,
    Cerulean,
    Chartreuse,
    Chrome,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.CobaltBlue))]
    CobaltBlue,
    Cocoa,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.CoolGrey))]
    CoolGrey,
    Copper,
    Coral,
    Cream,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.CrimsonRed))]
    CrimsonRed,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.CurryYellow))]
    CurryYellow,
    Cyan,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.DarkBrown))]
    DarkBrown,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.DarkMagenta))]
    DarkMagenta,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.DarkOrange))]
    DarkOrange,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.DarkPurple))]
    DarkPurple,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.DustyPink))]
    DustyPink,
    Ebony,
    Eggshell,
    Emerald,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.ForestGreen))]
    ForestGreen,
    Fuchsia,
    Gold,
    Goldenrod,
    Grape,
    Green,
    Grey,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.GunmetalBlue))]
    GunmetalBlue,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.GunmetalGrey))]
    GunmetalGrey,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.HarvestGold))]
    HarvestGold,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.HotPink))]
    HotPink,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.HunterGreen))]
    HunterGreen,
    Indigo,
    Ivory,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.JadeGreen))]
    JadeGreen,
    Khaki,
    Lavender,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LemonYellow))]
    LemonYellow,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LightBlue))]
    LightBlue,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LightBrown))]
    LightBrown,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LightGreen))]
    LightGreen,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LightOrange))]
    LightOrange,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LightYellow))]
    LightYellow,
    Lilac,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.LimeGreen))]
    LimeGreen,
    Magneta,
    Mahogany,
    Mango,
    Maroon,
    Mauve,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.MetallicBlue))]
    MetallicBlue,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.MetallicBronze))]
    MetallicBronze,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.MetallicCopper))]
    MetallicCopper,
    Mint,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.MochaBrown))]
    MochaBrown,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.MossGreen))]
    MossGreen,
    Mustard,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.NavyBlue))]
    NavyBlue,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.NeonGreen))]
    NeonGreen,
    Obsidian,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.OcherBrown))]
    OcherBrown,
    Olive,
    Orange,
    Orchid,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.CurryYellow))]
    PaleRose,
    Paprika,
    Peach,
    Pearl,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.PineGreen))]
    PineGreen,
    Pink,
    Platinum,
    Plum,
    Purple,
    Raspberry,
    Red,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.RedOrange))]
    RedOrange,
    Rose,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.RoseGold))]
    RoseGold,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.RoyalBlue))]
    RoyalBlue,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.RubyRed))]
    RubyRed,
    Rust,
    Salmon,
    Sand,
    Sapphire,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.ScarletRed))]
    ScarletRed,
    Silver,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.SkyBlue))]
    SkyBlue,
    Slate,
    Steel,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.StoneGreen))]
    StoneGreen,
    Tan,
    Tangerine,
    Taupe,
    Teal,
    Terracotta,
    Turquoise,
    Vermillion,
    Violet,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.VistaBlue))]
    VistaBlue,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.WarmGrey))]
    WarmGrey,
    White,
    Yellow,

    [Display(ResourceType = typeof(EntityColorTypeResource), Description = nameof(EntityColorTypeResource.YellowGreen))]
    YellowGreen,

    [Display(
        ResourceType = typeof(EntityColorTypeResource),
        Description = nameof(EntityColorTypeResource.YellowOrange))]
    YellowOrange,
}