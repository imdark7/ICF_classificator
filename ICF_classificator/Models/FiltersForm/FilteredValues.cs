using ICF_classificator.Extensions;

namespace ICF_classificator.Models.FiltersForm
{
    // Resharper
    public enum FilteredValues
    {
        [DisplayedName("Фамилия Пациента")] LastName,
        [DisplayedName("Имя Пациента")] FirstName,
        [DisplayedName("Отчество Пациента")] SurName,
        [DisplayedName("Пол ребенка")] Sex,
        [DisplayedName("Адрес (фактич.)")] Address,
        [DisplayedName("ФИО родителя (сопровождающего)")] ParentName,
        [DisplayedName("Дата рождения")] BirthDate,
        [DisplayedName("Гестационный возраст (недель)")] GestationAge,
        [DisplayedName("Масса тела при рождении (грамм)")] BirthWeight,
        [DisplayedName("Длина при рождении (см)")] BirthHeight,
        [DisplayedName("Окружность головы (см)")] BirthHeadSize,
        [DisplayedName("Окружность грудной клетки (см)")] BirthChestSize,
        [DisplayedName("Оценка по Апгар, 1")] ApgarFirst,
        [DisplayedName("Оценка по Апгар, 2")] ApgarSecond,
        [DisplayedName("Оценка по Апгар, 3")] ApgarThird,
        [DisplayedName("Инвалидность")] HasDisability,
        [DisplayedName("Госпитализация")] IsNotFirstHospitalization,
        [DisplayedName("Дата поступления")] HospitalizationDate,
        [DisplayedName("ИВЛ (длит-ть в днях)")] ALVDuration,
        [DisplayedName("CPAP (длит-ть в днях)")] CPAPDuration,
        [DisplayedName("Церебральная ишемия")] CerebralIschemia,
        [DisplayedName("ВЖК")] IVH,
        [DisplayedName("Менингит")] Meningitis,
        [DisplayedName("Энцефалит")] Encephalitis,
        [DisplayedName("Судорожный синдром (длит-ть в днях)")] ConvulsiveSyndromeDuration,
        [DisplayedName("Сепсис")] Sepsis,
        [DisplayedName("ГБН")] HDN,
        [DisplayedName("Геморрагический синдром")] VKDB,
        [DisplayedName("Анемия тяжелой степени")] Anemia,
        [DisplayedName("Гипербилирубинемия")] Hyperbilirubinemia,
        [DisplayedName("ЯНЭК")] UNEC,
        [DisplayedName("ВПР")] BirthDefect,
        [DisplayedName("Оперативное вмешательство")] Surgery,
        [DisplayedName("№ Историй болезни")] PatientHistory,
    }
}