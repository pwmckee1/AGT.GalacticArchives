namespace AGT.GalacticArchives.DependencyResolution;

public static class ContainerExtensions
{
    public static bool IsInjectableArtifactType(this Type type)
    {
        return type.Name.IsInjectableArtifact() &&
               !type.GetInterfaces().Contains(typeof(IHostedService));
    }

    private static bool IsInjectableArtifact(this string name)
    {
        return name.EndsWith("Manager") ||
               name.EndsWith("Service");
    }
}