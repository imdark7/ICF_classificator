using System;
using ICF_classificator.Extensions;

namespace ICF_classificator.Models.PatientDataModels
{
    public enum Gestation
    {
        [DisplayedName("Не известно")]
        Unknown,
        [DisplayedName("Недоношенный")]
        Premature,
        [DisplayedName("Доношенный")]
        Fullterm
    }
}