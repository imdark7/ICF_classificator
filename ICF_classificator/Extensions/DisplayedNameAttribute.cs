using System;

namespace ICF_classificator.Extensions
{
    public class DisplayedNameAttribute : Attribute
    {
        public readonly string DisplayedName;

        public DisplayedNameAttribute(string name)
        {
            DisplayedName = name;
        }
    }
}
