using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ICF_classificator.Extensions
{

    public static class EnumHelper<T>
    {
        public static IList<T> GetValues()
        {
            return typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public).Select(fi => (T)Enum.Parse(typeof(T), fi.Name, false)).ToList();
        }

        public static T Parse(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static T ParseByDisplayedNameAttributeValue(string attributeValue)
        {
            var fields = typeof(T).GetFields();
            var fieldInfo = fields.First(info => info.CustomAttributes.Any() && info.GetCustomAttribute<DisplayedNameAttribute>().DisplayedName == attributeValue);
            return (T)Enum.Parse(typeof(T), fieldInfo.Name);
        }

        public static IList<string> GetNames(Enum value)
        {
            return value.GetType().GetFields(BindingFlags.Static | BindingFlags.Public).Select(fi => fi.Name).ToList();
        }

        public static List<string> GetDisplayedValues()
        {
            var fields = typeof(T).GetFields();
            return (from fieldInfo in fields where fieldInfo.GetCustomAttributes<DisplayedNameAttribute>().Any() select fieldInfo.GetCustomAttribute<DisplayedNameAttribute>().DisplayedName).ToList();
        }

        //private static string LookupResource(Type resourceManagerProvider, string resourceKey)
        //{
        //    foreach (var staticProperty in resourceManagerProvider.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
        //    {
        //        if (staticProperty.PropertyType == typeof(System.Resources.ResourceManager))
        //        {
        //            var resourceManager = (System.Resources.ResourceManager)staticProperty.GetValue(null, null);
        //            return resourceManager.GetString(resourceKey);
        //        }
        //    }

        //    return resourceKey; // Fallback with the key name
        //}

        public static string GetDisplayedValue(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttributes = fieldInfo.GetCustomAttribute<DisplayedNameAttribute>(false);
            return descriptionAttributes.DisplayedName ?? value.ToString();
        }
    }
}