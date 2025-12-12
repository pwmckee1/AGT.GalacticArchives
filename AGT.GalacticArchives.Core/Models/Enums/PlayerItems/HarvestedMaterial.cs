using System.Diagnostics.CodeAnalysis;
using AGT.GalacticArchives.Core.Models.Enums.Planet;

namespace AGT.GalacticArchives.Core.Models.Enums.PlayerItems;

public class HarvestedMaterial
{
    public HarvestedMaterialType? Material { get; set; }
}

// Disable File may only contain a single type
#pragma warning disable SA1402
[SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty")]
public abstract record HarvestedMaterialType;

public record HarvestedBaseMaterialType(BaseMaterialTypes Material) : HarvestedMaterialType;

public record HarvestedExoticMaterialType(ExoticMaterialTypes Material) : HarvestedMaterialType;

public record HarvestedUniqueMaterialType(UniqueMaterialTypes Material) : HarvestedMaterialType;

public record HarvestedAtmosphereMaterialType(AtmosphereMaterialTypes Material) : HarvestedMaterialType;

public record HarvestedEdibleMaterialType(EdibleMaterialTypes Material) : HarvestedMaterialType;

public record HarvestedGlitchMaterialType(GlitchMaterialTypes Material) : HarvestedMaterialType;
#pragma warning restore SA1402