using System.Diagnostics.CodeAnalysis;
using AGT.GalacticArchives.Core.Models.Enums;

namespace AGT.GalacticArchives.Core.Models.InGame.Entities;
#pragma warning disable SA1402:File may only contain a single type

public class StarshipComponents
{
    public StarshipComponent? Component { get; set; }
}

[SuppressMessage("Minor Code Smell", "S2094:Classes should not be empty")]
public abstract record StarshipComponent;

public record StarshipModel(StarshipModelTypes Component) : StarshipComponent;

public record StarshipSubModel(StarshipSubModelTypes Component) : StarshipComponent;

public record StarshipWing(StarshipWingTypes Component) : StarshipComponent;

public record StarshipThruster(StarshipThrusterTypes Component) : StarshipComponent;

public record StarshipHullAccessory(StarshipHullAccessoryTypes Component) : StarshipComponent;

public record StarshipExtraHullAccessory(StarshipExtraHullAccessoryTypes Component) : StarshipComponent;

#pragma warning restore SA1402:File may only contain a single type