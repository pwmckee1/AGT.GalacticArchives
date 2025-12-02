using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using AGT.GalacticArchives.Services.Decorators;
using AGT.GalacticArchives.Services.Services.GameData;
using AGT.GalacticArchives.Services.Services.GameData.Interfaces;
using Autofac;

namespace AGT.GalacticArchives.DependencyResolution;

public class ServiceModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<GalaxyService>()
            .Named<IGalaxyService>(NamedKeys.Services.GalaxyService)
            .InstancePerLifetimeScope();

        builder.Register((c, _) => new ValidatedGalaxyServiceDecorator(
                c.ResolveNamed<IGalaxyService>(NamedKeys.Services.GalaxyService)))
            .As<IGalaxyService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<RegionService>()
            .Named<IRegionService>(NamedKeys.Services.RegionService)
            .InstancePerLifetimeScope();

        builder.Register((c, _) => new ValidatedRegionServiceDecorator(
                c.ResolveNamed<IRegionService>(NamedKeys.Services.RegionService),
                c.ResolveNamed<IGalaxyManager>(NamedKeys.Managers.GalaxyManager)))
            .As<IRegionService>()
            .InstancePerLifetimeScope();
    }
}