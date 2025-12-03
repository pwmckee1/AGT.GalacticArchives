namespace AGT.GalacticArchives.Core.Models.GameData.BaseEntities;

public class InnerSystemEntity : DatabaseEntity
{
    public Guid? PlanetId { get; set; }

    public Planet? Planet { get; set; }

    public Guid StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }
}