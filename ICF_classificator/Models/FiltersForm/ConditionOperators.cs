using ICF_classificator.Extensions;

namespace ICF_classificator.Models.FiltersForm
{
    public enum ContainsConditionOperators
    {
        [DisplayedName("Содержит")] Contain,
        [DisplayedName("Не содержит")] NotContain,
        [DisplayedName("Равно")] Equal,
        [DisplayedName("Не равно")] NotEqual
    }

    public enum CompareConditionOperators
    {
        [DisplayedName("Равно")] Equal,
        [DisplayedName("Не равно")] NotEqual,
        [DisplayedName("Больше")] More,
        [DisplayedName("Меньше")] Less
    }

    public enum EqualsConditionOperators
    {
        [DisplayedName("Равно")] Equal,
        [DisplayedName("Не равно")] NotEqual
    }

    public static class ConditionsHelper
    {
        public static string GetDisplayedName(this ContainsConditionOperators value) => EnumHelper<ContainsConditionOperators>.GetDisplayedValue(value);
        public static string GetDisplayedName(this CompareConditionOperators value) => EnumHelper<CompareConditionOperators>.GetDisplayedValue(value);
        public static string GetDisplayedName(this EqualsConditionOperators value) => EnumHelper<EqualsConditionOperators>.GetDisplayedValue(value);
    }
}