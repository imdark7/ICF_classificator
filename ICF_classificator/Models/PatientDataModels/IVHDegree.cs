using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    // ReSharper disable InconsistentNaming
    public enum IVHDegree
    {
        [DisplayedName("Нет")] Missing,
        [DisplayedName("I степень")] I,
        [DisplayedName("II степень")] II,
        [DisplayedName("III степень")] III,
        [DisplayedName("IV степень")] IV
    }
}