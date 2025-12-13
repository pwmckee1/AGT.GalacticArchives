using AGT.GalacticArchives.Core.Constants.Application;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Services.Decorators;
using AGT.GalacticArchives.Services.Interfaces.Services;
using AGT.GalacticArchives.Services.Services.Entities;
using AGT.GalacticArchives.Services.Services.Environments;
using AGT.GalacticArchives.Services.Services.Imports;
using Autofac;

namespace AGT.GalacticArchives.DependencyResolution;

public class ServiceModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<RegionService>()
            .Named<IRegionService>(NamedKeys.Services.RegionService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedRegionServiceDecorator(
                c.ResolveNamed<IRegionService>(NamedKeys.Services.RegionService)))
            .As<IRegionService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarSystemService>()
            .Named<IStarSystemService>(NamedKeys.Services.StarSystemService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedStarSystemServiceDecorator(
                c.ResolveNamed<IStarSystemService>(NamedKeys.Services.StarSystemService)))
            .As<IStarSystemService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlanetService>()
            .Named<IPlanetService>(NamedKeys.Services.PlanetService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedPlanetServiceDecorator(
                c.ResolveNamed<IPlanetService>(NamedKeys.Services.PlanetService)))
            .As<IPlanetService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<FaunaService>()
            .Named<IFaunaService>(NamedKeys.Services.FaunaService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedFaunaServiceDecorator(
                c.ResolveNamed<IFaunaService>(NamedKeys.Services.FaunaService)))
            .As<IFaunaService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<MultiToolService>()
            .Named<IMultiToolService>(NamedKeys.Services.MultiToolService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedMultiToolServiceDecorator(
                c.ResolveNamed<IMultiToolService>(NamedKeys.Services.MultiToolService)))
            .As<IMultiToolService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlayerBaseService>()
            .Named<IPlayerBaseService>(NamedKeys.Services.PlayerBaseService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedPlayerBaseServiceDecorator(
                c.ResolveNamed<IPlayerBaseService>(NamedKeys.Services.PlayerBaseService)))
            .As<IPlayerBaseService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PointOfInterestService>()
            .Named<IPointOfInterestService>(NamedKeys.Services.PointOfInterestService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedPointOfInterestServiceDecorator(
                c.ResolveNamed<IPointOfInterestService>(NamedKeys.Services.PointOfInterestService)))
            .As<IPointOfInterestService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<SettlementService>()
            .Named<ISettlementService>(NamedKeys.Services.SettlementService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedSettlementServiceDecorator(
                c.ResolveNamed<ISettlementService>(NamedKeys.Services.SettlementService)))
            .As<ISettlementService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarshipService>()
            .Named<IStarshipService>(NamedKeys.Services.StarshipService)
            .InstancePerLifetimeScope();

        builder
            .Register((c, _) => new ValidatedStarshipServiceDecorator(
                c.ResolveNamed<IStarshipService>(NamedKeys.Services.StarshipService)))
            .As<IStarshipService>()
            .InstancePerLifetimeScope();

        builder
            .RegisterType<FaunaImportService>()
            .Named<IImportService>(NamedKeys.Services.FaunaImportService)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<MultiToolImportService>()
            .Named<IImportService>(NamedKeys.Services.MultiToolImportService)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlanetImportService>()
            .Named<IImportService>(NamedKeys.Services.PlanetImportService)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlayerBaseImportService>()
            .Named<IImportService>(NamedKeys.Services.PlayerBaseImportService.GetDescription())
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PointOfInterestImportService>()
            .Named<IImportService>(NamedKeys.Services.PointOfInterestImportService.GetDescription())
            .InstancePerLifetimeScope();

        builder
            .RegisterType<RegionImportService>()
            .Named<IImportService>(NamedKeys.Services.RegionImportService.GetDescription())
            .InstancePerLifetimeScope();

        builder
            .RegisterType<SettlementImportService>()
            .Named<IImportService>(NamedKeys.Services.SettlementImportService.GetDescription())
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarSystemImportService>()
            .Named<IImportService>(NamedKeys.Services.StarshipImportService.GetDescription())
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarshipImportService>()
            .Named<IImportService>(NamedKeys.Services.StarSystemImportService.GetDescription())
            .InstancePerLifetimeScope();
    }
}