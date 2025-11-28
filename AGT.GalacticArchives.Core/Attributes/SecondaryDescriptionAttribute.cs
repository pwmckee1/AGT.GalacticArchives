namespace AGT.GalacticArchives.Core.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class SecondaryDescriptionAttribute : Attribute
{
    public SecondaryDescriptionAttribute(string secondaryDescription)
    {
        SecondaryDescription = secondaryDescription;
    }

    public string SecondaryDescription { get; private set; }
}