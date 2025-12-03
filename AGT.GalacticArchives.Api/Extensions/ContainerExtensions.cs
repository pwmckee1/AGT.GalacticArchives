namespace AGT.GalacticArchives.Extensions;

public static class ContainerExtensions
{
    extension(Type type)
    {
        public bool IsInjectableArtifactType()
        {
            return type.Name.IsInjectableArtifact() &&
                   !type.GetInterfaces().Contains(typeof(IHostedService));
        }
    }

    extension(string name)
    {
        private bool IsInjectableArtifact()
        {
            return name.EndsWith("Manager") ||
                   name.EndsWith("Service");
        }
    }
}