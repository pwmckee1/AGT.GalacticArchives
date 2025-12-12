using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Handlers.Validation.Imports;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using Autofac;

namespace AGT.GalacticArchives.DependencyResolution;

public class HandlerModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterType<FaunaImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.FaunaImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<MultiToolImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.MultiToolImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlanetImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.PlanetImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PlayerBaseImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.PlayerBaseImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<PointOfInterestImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.PointOfInterestImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<RegionImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.RegionImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<SettlementImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.SettlementImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarshipImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.StarshipImportValidationHandler)
            .InstancePerLifetimeScope();

        builder
            .RegisterType<StarSystemImportValidationHandler>()
            .Named<IImportValidationHandler>(NamedKeys.Handlers.StarSystemImportValidationHandler)
            .InstancePerLifetimeScope();
    }
}