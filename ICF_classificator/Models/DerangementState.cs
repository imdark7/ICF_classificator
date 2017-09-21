using System;

namespace ICF_classificator.Models
{
    public enum DerangementState
    {
        [DisplayedName("Не задано")]
        Unknown = 0,
        [DisplayedName("Норма")]
        Normal = 1,
        [DisplayedName("Нарушено")]
        Deranged = 2
    }

    public class DisplayedNameAttribute : Attribute
    {
        public readonly string DisplayedName;

        public DisplayedNameAttribute(string name)
        {
            DisplayedName = name;
        }
    }

    public static class DerangementStateHelper
    {
        public static string DisplayedName(this DerangementState state)
        {
            var attributes =
                typeof(DerangementState).GetField(state.ToString())
                    .GetCustomAttributes(typeof(DisplayedNameAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return ((DisplayedNameAttribute) attributes[attributes.Length - 1]).DisplayedName;
            }

            throw new NotImplementedException("Строковое имя для элемента enum не задано");
        }
    }
}
