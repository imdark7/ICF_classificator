using System.Collections.Generic;
using System.Linq;
using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    // ReSharper disable InconsistentNaming
    public class IVHModel
    {
        public IVHDegree Degree;
        public IVHLocalization Localization;

        /// <summary>
        /// Строка формата 'Degree (Localization)'
        /// </summary>
        /// <returns></returns>
        public string GetReportString() => $"{EnumHelper<IVHDegree>.GetDisplayedValue(Degree)}{GetLocalizationString()}";
        private string GetLocalizationString() => Localization != IVHLocalization.Unknown ? $" ({EnumHelper<IVHLocalization>.GetDisplayedValue(Localization)})" : "";

        public static List<string> GetDisplayedValues()
        {
            return (from displayValue in EnumHelper<IVHDegree>.GetDisplayedValues() from value in EnumHelper<IVHLocalization>.GetDisplayedValues() select $"{displayValue} ({value})").ToList();
        }

        public static IVHModel GetModelByReportString(string reportString)
        {
            var strings = reportString.Split(' ');
            var model = new IVHModel {Degree = EnumHelper<IVHDegree>.ParseByDisplayedNameAttributeValue(strings[0])};

            model.Localization = strings.Length == 1
                ? model.Localization = IVHLocalization.Unknown
                : EnumHelper<IVHLocalization>.ParseByDisplayedNameAttributeValue(strings[1]);
            return model;
        }
    }
}