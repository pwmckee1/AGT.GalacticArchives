using System.Reflection;
using AutoFixture.Kernel;

namespace AGT.GalacticArchives.Tests.AutoFixture;

public class IgnoreVirtualMembers : ISpecimenBuilder
{
    public object Create(object request, ISpecimenContext context)
    {
        ArgumentNullException.ThrowIfNull(context);

        var pi = request as PropertyInfo;
        if (pi == null)
        {
            return new NoSpecimen();
        }

        return pi.GetGetMethod()!.IsVirtual ? null! : new NoSpecimen();
    }
}