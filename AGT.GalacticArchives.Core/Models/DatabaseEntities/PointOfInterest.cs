using System.ComponentModel.DataAnnotations;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Models.DatabaseEntities;

public class PointOfInterest : IDatabaseEntity
{
    public Guid PointOfInterestId { get; set; } = Guid.NewGuid();

    public Guid Id => PointOfInterestId;

    [Display(ResourceType = typeof(PointOfInterestResource), Description = nameof(PointOfInterestResource.Name))]
    public string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public string? Type { get; set; }

    public string? YYFirstCoordinate { get; set; }

    public string? XXSecondCoordinate { get; set; }

    public string? NotesOrDescription { get; set; }

    public string? DateOfSurvey { get; set; }

    public string? Surveyor { get; set; }

    public string? Release { get; set; }
}