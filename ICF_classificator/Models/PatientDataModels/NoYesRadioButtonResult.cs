using System;
using System.Linq;
using System.Reflection;
using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    public enum NoYesRadioButtonResult
    {
        [DisplayedName("Нет")] No,
        [DisplayedName("Да")] Yes
    }

    public static class NoYesRadioButtonResultHelper
    {
        public static string GetReportString(this NoYesRadioButtonResult result)
        {
            return EnumHelper<NoYesRadioButtonResult>.GetDisplayedValue(result);
        }

        public static NoYesRadioButtonResult GetNameByDisplayedNameAttributeValue(string attributeValue)
        {
            var x =
                typeof(NoYesRadioButtonResult).GetFields()
                    .First(info => info.GetCustomAttribute<DisplayedNameAttribute>().DisplayedName == attributeValue);
            return (NoYesRadioButtonResult)Enum.Parse(typeof(NoYesRadioButtonResult), x.Name);
        }
    }
}