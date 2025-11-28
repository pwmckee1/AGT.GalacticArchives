using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AGT.GalacticArchives.Core.Attributes;
using CsvHelper.Configuration.Attributes;

namespace AGT.GalacticArchives.Core.Extensions;

public static class AttributeExtensions
    {
        /// <summary>
        ///     Validates attribute(s) on a property
        /// </summary>
        /// <param name="objectToValidate">The object to validate</param>
        /// <param name="propertyName">The name of the property to validate</param>
        /// <param name="propertyToValidate">The property on the object to validate</param>
        public static List<ValidationResult> ValidateProperty(this object objectToValidate, string propertyName, object? propertyToValidate)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(objectToValidate, null, null) { MemberName = propertyName };
            Validator.TryValidateProperty(propertyToValidate, validationContext, validationResults);

            return validationResults;
        }

        /// <summary>
        /// Get attribute from property - null if attribute is not found
        /// </summary>
        /// <typeparam name="T">typeof class containing attribute</typeparam>
        /// <typeparam name="TAttribute">typeof attribute</typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
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
        ///     Get Localized Description from Display, Description, or Name Attribute on property
        /// </summary>
        /// <typeparam name="T">typeof class or enum</typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetDescription<T>(this T property)
        {
            var description = property?.ToString()!;
            return GetDescription<T>(description);
        }

        /// <summary>
        ///      Get Localized Description from Display, Description, or Name Attribute on property
        /// </summary>
        /// <typeparam name="T">typeof class or enum containing property</typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
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
        ///     Get Localized Description from Display, Description, or Name Attribute on fieldInfo
        /// </summary>
        /// <param name="fieldInfo"></param>
        /// <returns></returns>
        public static string GetDescription(this FieldInfo fieldInfo)
        {
            var displayAttribute = fieldInfo.GetCustomAttribute<DisplayAttribute>();
            var descriptionAttribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            var nameAttribute = fieldInfo.GetCustomAttribute<NameAttribute>();
            return GetDescription(displayAttribute, descriptionAttribute, nameAttribute, fieldInfo.Name);
        }

        /// <summary>
        ///     Get Localized Description from Display, Description, or Name Attribute on propertyInfo
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
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