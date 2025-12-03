using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Managers.Database;
using AGT.GalacticArchives.Core.Managers.Database.Interfaces;
using AGT.GalacticArchives.Core.Managers.GameData;
using AGT.GalacticArchives.Core.Managers.GameData.Caching;
using AGT.GalacticArchives.Core.Managers.GameData.Interfaces;
using Autofac;

namespace AGT.GalacticArchives.DependencyResolution;

public class ManagerModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<FirestoreManager>()
            .Named<IFirestoreManager>(NamedKeys.Managers.FirestoreManager)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<GalaxyManager>()
            .Named<IGalaxyManager>(NamedKeys.Managers.GalaxyManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedGalaxyManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IGalaxyManager>(NamedKeys.Managers.GalaxyManager)))
            .As<IGalaxyManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<RegionManager>()
            .Named<IRegionManager>(NamedKeys.Managers.RegionManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedRegionManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IRegionManager>(NamedKeys.Managers.RegionManager)))
            .As<IRegionManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarSystemManager>()
            .Named<IStarSystemManager>(NamedKeys.Managers.StarSystemManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedStarSystemManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IStarSystemManager>(NamedKeys.Managers.StarSystemManager)))
            .As<IStarSystemManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlanetManager>()
            .Named<IPlanetManager>(NamedKeys.Managers.PlanetManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedPlanetManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPlanetManager>(NamedKeys.Managers.PlanetManager)))
            .As<IPlanetManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<InnerSystemEntityManager>()
            .Named<IInnerSystemEntityManager>(NamedKeys.Managers.InnerSystemEntityManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedInnerSystemEntityManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IInnerSystemEntityManager>(NamedKeys.Managers.InnerSystemEntityManager)))
            .As<IInnerSystemEntityManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<FaunaManager>()
            .Named<IFaunaManager>(NamedKeys.Managers.FaunaManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedFaunaManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IFaunaManager>(NamedKeys.Managers.FaunaManager)))
            .As<IFaunaManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<MultiToolManager>()
            .Named<IMultiToolManager>(NamedKeys.Managers.MultiToolManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedMultiToolManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IMultiToolManager>(NamedKeys.Managers.MultiToolManager)))
            .As<IMultiToolManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlayerBaseManager>()
            .Named<IPlayerBaseManager>(NamedKeys.Managers.PlayerBaseManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedPlayerBaseManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPlayerBaseManager>(NamedKeys.Managers.PlayerBaseManager)))
            .As<IPlayerBaseManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PointOfInterestManager>()
            .Named<IPointOfInterestManager>(NamedKeys.Managers.PointOfInterestManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedPointOfInterestManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IPointOfInterestManager>(NamedKeys.Managers.PointOfInterestManager)))
            .As<IPointOfInterestManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<SettlementManager>()
            .Named<ISettlementManager>(NamedKeys.Managers.SettlementManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedSettlementManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<ISettlementManager>(NamedKeys.Managers.SettlementManager)))
            .As<ISettlementManager>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarshipManager>()
            .Named<IStarshipManager>(NamedKeys.Managers.StarshipManager)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new CachedStarshipManager(
                c.Resolve<ICacheManager>(),
                c.ResolveNamed<IStarshipManager>(NamedKeys.Managers.StarshipManager)))
            .As<IStarshipManager>()
            .InstancePerLifetimeScope();
    }
}