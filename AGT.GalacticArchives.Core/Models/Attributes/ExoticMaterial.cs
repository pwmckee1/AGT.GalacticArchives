using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Attributes;

public record ExoticMaterial(ExoticMaterialTypes Material) : MaterialValue;