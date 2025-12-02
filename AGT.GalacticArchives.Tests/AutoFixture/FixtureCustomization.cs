using System.Linq.Expressions;
using System.Reflection;
using AutoFixture;
using AutoFixture.AutoMoq;

namespace AGT.GalacticArchives.Tests.AutoFixture;

public sealed class FixtureCustomization<T>
{
    public FixtureCustomization(Fixture fixture)
    {
        Fixture = fixture;
    }

    public Fixture Fixture { get; set; }

    public static string? GetPropertyName<TProp>(Expression<Func<T, TProp>> expr)
    {
        var memberAccess = expr.Body as MemberExpression;
        var propertyInfo = memberAccess?.Member as PropertyInfo;
        string? propertyName = propertyInfo?.Name;

        return propertyName;
    }

    /// <summary>
    /// Customizes the fixture by overriding a specific property with a given value
    /// </summary>
    /// <typeparam name="TProp">The type of the property to override</typeparam>
    /// <param name="expr">Expression that specifies which property to override</param>
    /// <param name="value">The value to set for the specified property</param>
    /// <returns>The current fixture customization instance for method chaining</returns>
    public FixtureCustomization<T> With<TProp>(Expression<Func<T, TProp>> expr, TProp value)
    {
        Fixture.Customizations.Add(new OverridePropertyBuilder<T, TProp>(expr, value));

        return this;
    }

    public T Create(int recursionDepth = 1, bool ignoreVirtualMembers = true)
    {
        if (ignoreVirtualMembers) Fixture.Customizations.Add(new IgnoreVirtualMembers());

        Fixture.Customize(new AutoMoqCustomization());
        Fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
        Fixture.Behaviors.Add(new OmitOnRecursionBehavior(recursionDepth));

        AutoFixtureHelper.RegisterTypes(Fixture);

        return Fixture.Create<T>();
    }

    public IEnumerable<T> CreateMany(int? count, bool ignoreVirtualMembers = true)
    {
        if (ignoreVirtualMembers) Fixture.Customizations.Add(new IgnoreVirtualMembers());

        Fixture.Customize(new AutoMoqCustomization());
        Fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
        Fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        AutoFixtureHelper.RegisterTypes(Fixture);

        return count.HasValue ? Fixture.CreateMany<T>(count.Value) : Fixture.CreateMany<T>();
    }
}