using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Attributes;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Extensions;

public static class AttributeExtensions
{
    /// <summary>
    ///     Validates attribute(s) on a property.
    /// </summary>
    /// <param name="objectToValidate">The object to validate.</param>
    /// <param name="propertyName">The name of the property to validate.</param>
    /// <param name="propertyToValidate">The property on the object to validate.</param>
    /// <returns>the results of the validation.</returns>
    public static List<ValidationResult> ValidateProperty(
        this object objectToValidate,
        string propertyName,
        object? propertyToValidate)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(objectToValidate, null, null) { MemberName = propertyName };
        Validator.TryValidateProperty(propertyToValidate, validationContext, validationResults);

        return validationResults;
    }

    /// <summary>
    /// Get an attribute from property - null if the attribute is not found.
    /// </summary>
    /// <typeparam name="T">typeof class containing attribute.</typeparam>
    /// <typeparam name="TAttribute">typeof attribute.</typeparam>
    /// <param name="property">property to get attribute from.</param>
    /// <returns>the custom attribute if found, otherwise null.</returns>
    public static TAttribute? GetAttribute<T, TAttribute>(this T property)
        where TAttribute : Attribute
    {
        var type = typeof(T);
        var fieldInfo = type.GetField(property?.ToString()!);
        return fieldInfo != null
            ? fieldInfo.GetCustomAttribute<TAttribute>()
            : null;
    }

    public static string? GetSecondaryDescription<T>(this T property)
    {
        var secondaryDescriptionAttribute = property.GetAttribute<T, SecondaryDescriptionAttribute>();
        return secondaryDescriptionAttribute?.SecondaryDescription;
    }

    /// <summary>
    ///     Get Localized Description from Display, Description, or Name Attribute on property.
    /// </summary>
    /// <typeparam name="T">typeof class or enum.</typeparam>
    /// <param name="property">property to get description from.</param>
    /// <returns>value of the description attribute.</returns>
    public static string GetDescription<T>(this T property)
    {
        string description = property?.ToString()!;
        return GetDescription<T>(description);
    }

    /// <summary>
    ///      Get Localized Description from Display, Description, or Name Attribute on property.
    /// </summary>
    /// <typeparam name="T">typeof class or enum containing property.</typeparam>
    /// <param name="propertyName">property to get description from.</param>
    /// <returns>description attribute of a property field or the main property name if a field with the name of the description attribute doesn't exist.</returns>
    public static string GetDescription<T>(this string propertyName)
    {
        string description = propertyName;
        var type = typeof(T);
        var fieldInfo = type.GetField(description);
        if (fieldInfo != null)
        {
            description = fieldInfo.GetDescription();
        }

        return description;
    }

    /// <summary>
    ///     Get Localized Description from Display, Description, or Name Attribute on fieldInfo.
    /// </summary>
    /// <param name="fieldInfo">the fieldInfo to get the custom description attribute from.</param>
    /// <returns>the corresponding description attribute based on which attribute is found.</returns>
    public static string GetDescription(this FieldInfo fieldInfo)
    {
        var displayAttribute = fieldInfo.GetCustomAttribute<DisplayAttribute>();
        var descriptionAttribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
        var nameAttribute = fieldInfo.GetCustomAttribute<NameAttribute>();
        return GetDescription(displayAttribute, descriptionAttribute, nameAttribute, fieldInfo.Name);
    }

    /// <summary>
    ///     Get Localized Description from Display, Description, or Name Attribute on propertyInfo.
    /// </summary>
    /// <param name="propertyInfo">the propertyInfo to get the custom description attribute from.</param>
    /// <returns>the corresponding description attribute based on which attribute is found.</returns>
    public static string GetDescription(this PropertyInfo propertyInfo)
    {
        var displayAttribute = propertyInfo.GetCustomAttribute<DisplayAttribute>();
        var descriptionAttribute = propertyInfo.GetCustomAttribute<DescriptionAttribute>();
        var nameAttribute = propertyInfo.GetCustomAttribute<NameAttribute>();
        return GetDescription(displayAttribute, descriptionAttribute, nameAttribute, propertyInfo.Name);
    }

    private static string GetDescription(
        DisplayAttribute? displayAttribute,
        DescriptionAttribute? descriptionAttribute,
        NameAttribute? nameAttribute,
        string defaultValue)
    {
        string description;

        // Get localized Description from the Display attribute
        if (displayAttribute != null)
        {
            description = displayAttribute.GetDescription()!;
        }

        // Get Description from the Description attribute
        else if (descriptionAttribute != null)
        {
            description = descriptionAttribute.Description;
        }

        // Get Description from the Name attribute
        else if (nameAttribute != null)
        {
            description = nameAttribute.Names.FirstOrDefault() ?? string.Empty;
        }

        // Get FieldInfo Name if there are no attributes
        else
        {
            description = defaultValue;
        }

        return description;
    }
}