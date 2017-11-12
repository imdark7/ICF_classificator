using System.Collections.Generic;
using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    public enum PatientSex
    {
        [DisplayedName("Муж")]Male,
        [DisplayedName("Жен")]Female
    }

    public static class PatientSexHelper
    {
        public static string GetDisplayedName(this PatientSex sex) => EnumHelper<PatientSex>.GetDisplayedValue(sex);
    }
}