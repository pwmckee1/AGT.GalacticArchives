using AGT.GalacticArchives.Tests.Helpers;
using Autofac;

namespace AGT.GalacticArchives.Tests;

[TestFixture]
public class AutoMapperSpecs
{
    [Test]
    public void VerifyMappingConfiguration()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.InitializeAutoMapper();

        var container = containerBuilder.Build();
        container.ValidateMapperConfiguration();
    }
}