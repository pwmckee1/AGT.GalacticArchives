using System.Reflection;
using Autofac;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;

namespace AGT.GalacticArchives.Tests.Helpers;

public static class AutoMapperHelper
{
    public static void InitializeAutoMapper(this ContainerBuilder containerBuilder)
    {
        var targetAssemblies = AssemblyHelpers.GetAllAssemblies();

        containerBuilder.RegisterAutoMapper(false, targetAssemblies);
        containerBuilder.RegisterAutoMapperTypes(targetAssemblies);
    }

    public static void ValidateMapperConfiguration(this IContainer container)
    {
        var mapperConfiguration = container.Resolve<MapperConfiguration>();
        mapperConfiguration.AssertConfigurationIsValid();
    }

    private static void RegisterAutoMapperTypes(this ContainerBuilder containerBuilder, Assembly[] assemblies)
    {
        var automapperTypes = new HashSet<Type>
        {
            typeof(IValueResolver<,,>),
            typeof(IMemberValueResolver<,,,>),
            typeof(ITypeConverter<,>),
            typeof(IValueConverter<,>),
            typeof(IMappingAction<,>),
        };

        containerBuilder.RegisterAssemblyTypes(assemblies)
            .Where(t => t.IsClass && !t.IsAbstract && (ImplementsAutoMapperTypes(t) || t.GetTypeInfo().ImplementedInterfaces.Any(ImplementsAutoMapperTypes)))
            .InstancePerDependency();

        bool ImplementsAutoMapperTypes(Type type)
        {
            return type.GetTypeInfo().IsGenericType && automapperTypes.Contains(type.GetGenericTypeDefinition());
        }
    }
}