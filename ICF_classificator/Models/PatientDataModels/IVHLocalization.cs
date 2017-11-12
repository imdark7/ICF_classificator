using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    // ReSharper disable InconsistentNaming
    public enum IVHLocalization
    {
        [DisplayedName("Не известно")] Unknown,
        [DisplayedName("Справа")] Right,
        [DisplayedName("Слева")] Left,
        [DisplayedName("Справа и слева")] RightAndLeft
    }
}