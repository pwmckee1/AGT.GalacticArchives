using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData;
using AGT.GalacticArchives.Core.Managers.GameData.Caching;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
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

        builder.RegisterType<RegionManager>()
            .Named<IRegionManager>(nameof(RegionManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedRegionManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IRegionManager>(nameof(RegionManager))))
            .As<IRegionManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<StarSystemManager>()
            .Named<IStarSystemManager>(nameof(StarSystemManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedStarSystemManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IStarSystemManager>(nameof(StarSystemManager))))
            .As<IStarSystemManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<FaunaManager>()
            .Named<IFaunaManager>(nameof(FaunaManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedFaunaManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IFaunaManager>(nameof(FaunaManager))))
            .As<IFaunaManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<MultiToolManager>()
            .Named<IMultiToolManager>(nameof(MultiToolManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedMultiToolManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IMultiToolManager>(nameof(MultiToolManager))))
            .As<IMultiToolManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<PlanetManager>()
            .Named<IPlanetManager>(nameof(PlanetManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedPlanetManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPlanetManager>(nameof(PlanetManager))))
            .As<IPlanetManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<PlayerBaseManager>()
            .Named<IPlayerBaseManager>(nameof(PlayerBaseManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedPlayerBaseManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPlayerBaseManager>(nameof(PlayerBaseManager))))
            .As<IPlayerBaseManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<PointOfInterestManager>()
            .Named<IPointOfInterestManager>(nameof(PointOfInterestManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedPointOfInterestManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPointOfInterestManager>(nameof(PointOfInterestManager))))
            .As<IPointOfInterestManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<SettlementManager>()
            .Named<ISettlementManager>(nameof(SettlementManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedSettlementManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<ISettlementManager>(nameof(SettlementManager))))
            .As<ISettlementManager>()
            .InstancePerLifetimeScope();

        builder.RegisterType<StarshipManager>()
            .Named<IStarshipManager>(nameof(StarshipManager))
            .InstancePerLifetimeScope();

        builder.Register((c, parameters) => new CachedStarshipManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IStarshipManager>(nameof(StarshipManager))))
            .As<IStarshipManager>()
            .InstancePerLifetimeScope();
    }
}