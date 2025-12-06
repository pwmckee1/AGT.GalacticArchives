using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Attributes;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Extensions;

public static class AttributeExtensions
{
    /// <param name="property"></param>
    /// <typeparam name="T">typeof class containing attribute</typeparam>
    extension<T>(T property)
    {
        /// <summary>
        /// Get attribute from property - null if attribute is not found
        /// </summary>
        /// <typeparam name="TAttribute">typeof attribute</typeparam>
        /// <returns></returns>
        public TAttribute? GetAttribute<TAttribute>()
            where TAttribute : Attribute
        {
            var type = typeof(T);
            var fieldInfo = type.GetField(property?.ToString()!);
            return fieldInfo != null
                ? fieldInfo.GetCustomAttribute<TAttribute>()
                : null;
        }

        public string? GetSecondaryDescription()
        {
            var secondaryDescriptionAttribute = property.GetAttribute<T, SecondaryDescriptionAttribute>();
            return secondaryDescriptionAttribute?.SecondaryDescription;
        }

        /// <summary>
        ///     Get Localized Description from Display, Description, or Name Attribute on property
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            var description = property?.ToString()!;
            return GetDescription<T>(description);
        }
    }

    /// <param name="objectToValidate">The object to validate</param>
    extension(object objectToValidate)
    {
        /// <summary>
        ///     Validates attribute(s) on a property
        /// </summary>
        /// <param name="propertyName">The name of the property to validate</param>
        /// <param name="propertyToValidate">The property on the object to validate</param>
        public List<ValidationResult> ValidateProperty(
            string propertyName,
            object? propertyToValidate)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(objectToValidate, null, null) { MemberName = propertyName };
            Validator.TryValidateProperty(propertyToValidate, validationContext, validationResults);

            return validationResults;
        }
    }

    /// <param name="propertyName"></param>
    extension(string propertyName)
    {
        /// <summary>
        ///      Get Localized Description from Display, Description, or Name Attribute on property
        /// </summary>
        /// <typeparam name="T">typeof class or enum containing property</typeparam>
        /// <returns></returns>
        public string GetDescription<T>()
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
    }

    /// <param name="fieldInfo"></param>
    extension(FieldInfo fieldInfo)
    {
        /// <summary>
        ///     Get Localized Description from Display, Description, or Name Attribute on fieldInfo
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            var displayAttribute = fieldInfo.GetCustomAttribute<DisplayAttribute>();
            var descriptionAttribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            var nameAttribute = fieldInfo.GetCustomAttribute<NameAttribute>();
            return GetDescription(displayAttribute, descriptionAttribute, nameAttribute, fieldInfo.Name);
        }
    }

    /// <param name="propertyInfo"></param>
    extension(PropertyInfo propertyInfo)
    {
        /// <summary>
        ///     Get Localized Description from Display, Description, or Name Attribute on propertyInfo
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            var displayAttribute = propertyInfo.GetCustomAttribute<DisplayAttribute>();
            var descriptionAttribute = propertyInfo.GetCustomAttribute<DescriptionAttribute>();
            var nameAttribute = propertyInfo.GetCustomAttribute<NameAttribute>();
            return GetDescription(displayAttribute, descriptionAttribute, nameAttribute, propertyInfo.Name);
        }
    }

    private static string GetDescription(
        DisplayAttribute? displayAttribute,
        DescriptionAttribute? descriptionAttribute,
        NameAttribute? nameAttribute,
        string defaultValue)
    {
        string description;

        // Get localized Description from Display attribute
        if (displayAttribute != null)
        {
            description = displayAttribute.GetDescription()!;
        }

        // Get Description from Description attribute
        else if (descriptionAttribute != null)
        {
            description = descriptionAttribute.Description;
        }

        // Get Description from Name attribute
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