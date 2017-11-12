using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    public enum CerebralIschemiaDegree
    {
        [DisplayedName("Нет")] None,
        [DisplayedName("Легкая")] Easy,
        [DisplayedName("Средняя")] Medium,
        [DisplayedName("Тяжелая")] Severe
    }

    public static class CerebralIschemiaHelper
    {
        public static string GetReportString(this CerebralIschemiaDegree value)
        {
            return EnumHelper<CerebralIschemiaDegree>.GetDisplayedValue(value);
        }
    }
}