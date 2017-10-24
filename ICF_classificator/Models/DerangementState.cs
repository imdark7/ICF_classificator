using ICF_classificator.Extensions;

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
}
