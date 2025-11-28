using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Managers.GameData;
using Autofac;

namespace AGT.GalacticArchives.DependencyResolution;

public class ManagerModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<GalaxyManager>()
            .Named<IGalaxyManager>(nameof(GalaxyManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedGalaxyManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IGalaxyManager>(nameof(GalaxyManager))))
            .As<IGalaxyManager>()
            .InstancePerLifetimeScope();
    }
}