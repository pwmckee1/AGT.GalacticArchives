using System.Reflection;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Managers.Caching.Interfaces;
using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.AppSettings;
using Autofac;

namespace AGT.GalacticArchives.Extensions;

public static class ContainerConfigurationExtensions
{
    /// <summary>
    /// Configures dependency injection by registering services and managers into the DI container.
    /// </summary>
    /// <param name="builder">The WebApplicationBuilder instance used to configure the application.</param>
    /// <param name="applicationSettings">The application settings containing configuration values.</param>
    /// <param name="environment">The hosting environment of the application.</param>
    public static void ConfigureDependencyInjection(
        this ContainerBuilder builder,
        ApplicationSettings applicationSettings,
        IHostEnvironment environment)
    {
        // Load assemblies from the application's bin directory
        var binPath = AppContext.BaseDirectory;
        var assemblyFiles = Directory.GetFiles(binPath, "AGT.*.dll");
        var assemblies = assemblyFiles
            .Select(f => Assembly.LoadFrom(f))
            .Concat(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName!.StartsWith("AGT")))
            .Distinct()
            .ToArray();

        builder.RegisterAssemblyTypes(assemblies)
            .Where(t => t.IsInjectableArtifactType())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        builder.RegisterType<InMemoryCacheManager>().As<ICacheManager>().SingleInstance();

        builder.RegisterAssemblyModules(assemblies);
    }
}