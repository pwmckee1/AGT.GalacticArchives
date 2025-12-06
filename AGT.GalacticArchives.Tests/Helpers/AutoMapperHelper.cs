using System.Reflection;
using Autofac;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;

namespace AGT.GalacticArchives.Tests.Helpers;

public static class AutoMapperHelper
{
    extension(ContainerBuilder containerBuilder)
    {
        public void InitializeAutoMapper()
        {
            var targetAssemblies = AssemblyHelpers.GetAllAssemblies();

            containerBuilder.RegisterAutoMapper(false, targetAssemblies);
            containerBuilder.RegisterAutoMapperTypes(targetAssemblies);
        }

        private void RegisterAutoMapperTypes(Assembly[] assemblies)
        {
            var automapperTypes = new HashSet<Type>
            {
                typeof(IValueResolver<,,>),
                typeof(IMemberValueResolver<,,,>),
                typeof(ITypeConverter<,>),
                typeof(IValueConverter<,>),
                typeof(IMappingAction<,>),
            };

            containerBuilder
                .RegisterAssemblyTypes(assemblies)
                .Where(t => t is { IsClass: true, IsAbstract: false } &&
                            (ImplementsAutoMapperTypes(t) ||
                             t.GetTypeInfo().ImplementedInterfaces.Any(ImplementsAutoMapperTypes)))
                .InstancePerDependency();

            bool ImplementsAutoMapperTypes(Type type)
            {
                return type.GetTypeInfo().IsGenericType && automapperTypes.Contains(type.GetGenericTypeDefinition());
            }
        }
    }

    extension(IContainer container)
    {
        public void ValidateMapperConfiguration()
        {
            var mapperConfiguration = container.Resolve<MapperConfiguration>();
            mapperConfiguration.AssertConfigurationIsValid();
        }
    }
}