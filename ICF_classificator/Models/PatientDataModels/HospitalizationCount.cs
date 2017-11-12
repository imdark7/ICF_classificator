using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    public enum HospitalizationCount
    {
        [DisplayedName("Первичная")] First,
        [DisplayedName("Повторная")] NotFirst
    }

    public static class HospitalizationCountHelper
    {
        public static string GetReportResult(this HospitalizationCount value)
        {
            return EnumHelper<HospitalizationCount>.GetDisplayedValue(value);
        }
    }
}