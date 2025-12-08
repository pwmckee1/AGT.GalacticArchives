using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.Attributes;

public record BaseMaterial(BaseMaterialTypes Material) : MaterialValue;