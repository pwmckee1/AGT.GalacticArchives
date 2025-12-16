using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using AutoFixture.Kernel;

namespace AGT.GalacticArchives.Tests.AutoFixture;

public class OverridePropertyBuilder<T, TProp>(Expression<Func<T, TProp>> expr, TProp value) : ISpecimenBuilder
{
    private readonly PropertyInfo _propertyInfo =
        (expr.Body as MemberExpression)?.Member as PropertyInfo ??
        throw new InvalidOperationException("invalid property expression");

    public object Create(object request, ISpecimenContext context)
    {
        var propertyInfo = request as PropertyInfo;
        var parameterInfo = request as ParameterInfo;

        if (propertyInfo == null && parameterInfo == null)
        {
            return new NoSpecimen();
        }

        string camelCase = Regex.Replace(
            _propertyInfo.Name,
            @"(\w)(.*)",
            m => m.Groups[1].Value.ToLower() + m.Groups[2]);

        if (propertyInfo != null && _propertyInfo.Name != propertyInfo.Name)
        {
            return new NoSpecimen();
        }

        if (parameterInfo != null &&
            (parameterInfo.ParameterType != typeof(TProp) || parameterInfo.Name != camelCase))
        {
            return new NoSpecimen();
        }

        return value!;
    }
}