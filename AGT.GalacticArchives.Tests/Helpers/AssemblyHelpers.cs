using System.Reflection;

namespace AGT.GalacticArchives.Tests.Helpers;

public static class AssemblyHelpers
{
    public static Assembly[] GetAllAssemblies()
    {
        var targetAssemblies = AppDomain
            .CurrentDomain.GetAssemblies()
            .Where(a => a.FullName!.StartsWith("ZanerBloser"))
            .ToHashSet();

        var referencedAssemblyNames = Assembly
            .GetExecutingAssembly()
            .GetReferencedAssemblies()
            .Where(an => an.FullName!.StartsWith("ZanerBloser"))
            .ToHashSet();

        var missingAssemblies = referencedAssemblyNames
            .Where(an => !targetAssemblies.Select(a => a.FullName).Contains(an.FullName))
            .ToHashSet();

        foreach (var missingAssembly in missingAssemblies)
        {
            targetAssemblies.Add(Assembly.Load(missingAssembly));
        }

        return targetAssemblies.ToArray();
    }
}