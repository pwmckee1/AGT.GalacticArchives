using AGT.GalacticArchives.Core.Interfaces.Caching;
using AGT.GalacticArchives.Core.Managers.Caching;
using AGT.GalacticArchives.Core.Models.AppSettings;
using Microsoft.Extensions.Caching.Distributed;

namespace AGT.GalacticArchives.Configuration;

public static class ContainerConfigurationExtensions
{
    /// <summary>
    /// Configures dependency injection by registering services and managers into the DI container.
    /// </summary>
    /// <param name="builder">The WebApplicationBuilder instance used to configure the application.</param>
    /// <param name="applicationSettings">The application settings containing configuration values.</param>
    /// <param name="environment">The hosting environment of the application.</param>
    public static void ConfigureDependencyInjection(
        this WebApplicationBuilder builder,
        ApplicationSettings applicationSettings,
        IHostEnvironment environment)
    {
        var types = typeof(Program).Assembly.GetTypes().Where(a => a.FullName!.StartsWith("AGT")).ToArray();

        // Register all Services
        foreach (var type in types.Where(a => a.Name.EndsWith("Service") && !a.IsInterface))
        {
            var interfaceType = type.GetInterfaces().FirstOrDefault();
            if (interfaceType != null)
            {
                builder.Services.AddScoped(interfaceType, type);
            }
        }

        // Register all Managers
        foreach (var type in types.Where(a => a.Name.EndsWith("Manager") && !a.IsInterface))
        {
            var interfaceType = type.GetInterfaces().FirstOrDefault();
            if (interfaceType != null)
            {
                builder.Services.AddScoped(interfaceType, type);
            }
        }

        builder.Services.AddMemoryCache();
        builder.Services.AddSingleton<IDistributedCache, InMemoryDistributedCacheAdapter>();
        builder.Services.AddSingleton<ICacheManager, InMemory>();
    }
}