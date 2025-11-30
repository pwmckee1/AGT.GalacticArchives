using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using AutoFixture.Kernel;

namespace AGT.GalacticArchives.Tests.AutoFixture
{
    public class OverridePropertyBuilder<T, TProp> : ISpecimenBuilder
    {
        private readonly PropertyInfo _propertyInfo;
        private readonly TProp _value;

        public OverridePropertyBuilder(Expression<Func<T, TProp>> expr, TProp value)
        {
            _propertyInfo = (expr.Body as MemberExpression)?.Member as PropertyInfo ?? throw new InvalidOperationException("invalid property expression");
            _value = value;
        }

        public object Create(object request, ISpecimenContext context)
        {
            var propertyInfo = request as PropertyInfo;
            var parameterInfo = request as ParameterInfo;

            if (propertyInfo == null && parameterInfo == null)
            {
                return new NoSpecimen();
            }

            var camelCase = Regex.Replace(_propertyInfo.Name, @"(\w)(.*)", m => m.Groups[1].Value.ToLower() + m.Groups[2]);

            if (propertyInfo != null && _propertyInfo.Name != propertyInfo.Name)
            {
                return new NoSpecimen();
            }

            if (parameterInfo != null && (parameterInfo.ParameterType != typeof(TProp) || parameterInfo.Name != camelCase))
            {
                return new NoSpecimen();
            }

            return _value!;
        }
    }
}
