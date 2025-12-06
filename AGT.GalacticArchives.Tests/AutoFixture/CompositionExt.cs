using AutoFixture;

namespace AGT.GalacticArchives.Tests.AutoFixture;

public static class CompositionExt
{
    extension(Fixture fixture)
    {
        public FixtureCustomization<T> For<T>()
        {
            return new FixtureCustomization<T>(fixture);
        }
    }
}