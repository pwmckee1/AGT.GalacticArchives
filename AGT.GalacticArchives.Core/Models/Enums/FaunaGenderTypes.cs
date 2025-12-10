using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.Enums;

public enum FaunaGenderTypes
{
    Alpha,
    Asymmetric,
    Asymptotic,
    Asynchronous,
    Circular,
    Electronic,
    Exotic,
    Female,
    Indeterminate,
    Male,
    Mutable,

    [Display(ResourceType = typeof(FaunaGenderTypeResource), Description = nameof(FaunaGenderTypeResource.NonBoolean))]
    NonBoolean,
    None,

    [Display(
        ResourceType = typeof(FaunaGenderTypeResource),
        Description = nameof(FaunaGenderTypeResource.NonEuclidean))]
    NonEuclidean,

    [Display(ResourceType = typeof(FaunaGenderTypeResource), Description = nameof(FaunaGenderTypeResource.NonUniform))]
    NonUniform,
    Orthogonal,
    Prime,
    Radical,
    Rational,
    Symmetric,
    Uninitialised,
    Unknown,
    Unmeasurable,
    Virtual,
}