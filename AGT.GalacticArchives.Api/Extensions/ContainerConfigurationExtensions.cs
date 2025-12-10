using System.Reflection;
using AGT.GalacticArchives.Core.Interfaces.Managers;
using AGT.GalacticArchives.Core.Managers.Caching;
using Autofac;

namespace AGT.GalacticArchives.Extensions;

public static class ContainerConfigurationExtensions
{
    /// <summary>
    /// Configures dependency injection by registering services and managers into the DI container.
    /// </summary>
    /// <param name="builder">The ContainerBuilder instance used to configure the application.</param>
    public static void ConfigureDependencyInjection(this ContainerBuilder builder)
    {
        // Load assemblies from the application's bin directory
        string binPath = AppContext.BaseDirectory;
        string[] assemblyFiles = Directory.GetFiles(binPath, "AGT.*.dll");
        var assemblies = assemblyFiles
            .Select(Assembly.LoadFrom)
            .Concat(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName!.StartsWith("AGT")))
            .Distinct()
            .ToArray();

        builder
            .RegisterAssemblyTypes(assemblies)
            .Where(t => t.IsInjectableArtifactType())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        builder.RegisterType<InMemoryCacheManager>().As<ICacheManager>().SingleInstance();

        builder.RegisterAssemblyModules(assemblies);
    }
}