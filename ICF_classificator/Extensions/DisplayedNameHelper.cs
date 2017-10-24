using System;
using ICF_classificator.Models;

namespace ICF_classificator.Extensions
{
    public static class DisplayedNameHelper
    {
        public static string DisplayedName(this DerangementState state)
        {
            var attributes =
                typeof(DerangementState).GetField(state.ToString())
                    .GetCustomAttributes(typeof(DisplayedNameAttribute), false);

            if (attributes.Length > 0)
            {
                return ((DisplayedNameAttribute) attributes[attributes.Length - 1]).DisplayedName;
            }

            throw new NotImplementedException("Строковое имя для элемента enum не задано");
        }

        public static string DisplayedName(this string fieldName)
        {
            var attributes =
                typeof(Patient).GetField(fieldName)
                    .GetCustomAttributes(typeof(DisplayedNameAttribute), false);

            if (attributes.Length > 0)
            {
                return ((DisplayedNameAttribute)attributes[attributes.Length - 1]).DisplayedName;
            }

            throw new NotImplementedException("Строковое имя для поля не задано");
        }
    }
}