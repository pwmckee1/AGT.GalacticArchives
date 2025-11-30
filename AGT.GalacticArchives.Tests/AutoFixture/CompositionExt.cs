using AutoFixture;

namespace AGT.GalacticArchives.Tests.AutoFixture
{
    public static class CompositionExt
    {
        public static FixtureCustomization<T> For<T>(this Fixture fixture)
        {
            return new FixtureCustomization<T>(fixture);
        }
    }
}
