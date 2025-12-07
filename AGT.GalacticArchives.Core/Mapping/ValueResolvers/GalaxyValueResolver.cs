using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AutoMapper;

namespace AGT.GalacticArchives.Core.Mapping.ValueResolvers;

public class GalaxyValueResolver(IMapper mapper)
    : IValueResolver<Region, RegionResponse, Guid?>,
        IValueResolver<StarSystem, StarSystemResponse, Guid?>,
        IValueResolver<Planet, PlanetResponse, Guid?>,
        IValueResolver<Region, RegionResponse, GalaxyResponse?>,
        IValueResolver<StarSystem, StarSystemResponse, GalaxyResponse?>,
        IValueResolver<Planet, PlanetResponse, GalaxyResponse?>
{
    public Guid? Resolve(Region source, RegionResponse destination, Guid? destMember, ResolutionContext context)
    {
        return source.Galaxy != null && source.GalaxyId != Guid.Empty
            ? source.GalaxyId
            : null;
    }

    public Guid? Resolve(StarSystem source, StarSystemResponse destination, Guid? destMember, ResolutionContext context)
    {
        return HasGalaxy(source) ? source.Region!.GalaxyId : null;
    }

    public Guid? Resolve(Planet source, PlanetResponse destination, Guid? destMember, ResolutionContext context)
    {
        return source.StarSystem != null &&
               HasGalaxy(source.StarSystem!)
            ? source.StarSystem?.Region?.GalaxyId
            : null;
    }

    public GalaxyResponse? Resolve(Region source, RegionResponse destination, GalaxyResponse? destMember, ResolutionContext context)
    {
        return source.Galaxy != null && source.GalaxyId != Guid.Empty
            ? mapper.Map<GalaxyResponse>(source.Galaxy)
            : null;
    }

    public GalaxyResponse? Resolve(StarSystem source, StarSystemResponse destination, GalaxyResponse? destMember, ResolutionContext context)
    {
        return HasGalaxy(source)
            ? mapper.Map<GalaxyResponse>(source.Region?.Galaxy)
            : null;
    }

    public GalaxyResponse? Resolve(Planet source, PlanetResponse destination, GalaxyResponse? destMember, ResolutionContext context)
    {
        return HasGalaxy(source.StarSystem!)
            ? mapper.Map<GalaxyResponse>(source.StarSystem?.Region?.Galaxy)
            : null;
    }

    private static bool HasGalaxy(StarSystem source)
    {
        return source.Region != null &&
               source.RegionId != Guid.Empty &&
               source.Region!.Galaxy != null &&
               source.Region!.GalaxyId != Guid.Empty;
    }
}