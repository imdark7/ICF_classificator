using System;
using ICF_classificator.Extensions;
using ICF_classificator.Models.PatientDataModels;

namespace ICF_classificator.Models
{
    public class Patient
    {
        // ReSharper disable InconsistentNaming
        public long Id;
        [DisplayedName("Фамилия")] public string LastName;
        [DisplayedName("Имя")] public string FirstName;
        [DisplayedName("Отчество")] public string SurName;
        [DisplayedName("Пол ребенка")] public PatientSex Sex;
        [DisplayedName("Адрес (фактич.)")] public string Address;
        [DisplayedName("ФИО родителя (сопровождающего)")] public string ParentName;
        [DisplayedName("Дата рождения")] public DateTime BirthDate;
        [DisplayedName("Гестационный возраст (в неделях)")] public int GestationAge;
        [DisplayedName("Масса тела при рождении (в граммах)")] public int BirthWeight;
        [DisplayedName("Длина при рождении (в см)")] public int BirthHeight;
        [DisplayedName("Окружность головы при рождении (в см)")] public int BirthHeadSize;
        [DisplayedName("Окружность грудной клетки при рождении (в см)")] public int BirthChestSize;
        [DisplayedName("Оценка по шкале Апгар")] public ApgarResult ApgarScale;
        [DisplayedName("Инвалидность")] public NoYesRadioButtonResult Disability;
        [DisplayedName("Госпитализация в отделение")] public HospitalizationCount Hospitalization;
        [DisplayedName("Дата поступления в отделение")] public DateTime HospitalizationDate;
        [DisplayedName("ИВЛ (Искусственная вентиляция легких)")] public int ALVDuration;
        [DisplayedName("CPAP")] public int CPAPDuration;
        [DisplayedName("Церебральная ишемия")] public CerebralIschemiaDegree CerebralIschemia;
        [DisplayedName("ВЖК (Внутрижелудочковое кровоизлияние)")] public IVHModel IVH;
        [DisplayedName("Менингит")] public NoYesRadioButtonResult Meningitis;
        [DisplayedName("Энцефалит")] public NoYesRadioButtonResult Encephalitis;
        [DisplayedName("Судорожный синдром")] public int ConvulsiveSyndromeDuration;
        [DisplayedName("Сепсис")] public NoYesRadioButtonResult Sepsis;
        [DisplayedName("ГБН (Гемолитическая болезнь новорожденных)")] public NoYesRadioButtonResult HDN;
        [DisplayedName("Геморрагический синдром")] public NoYesRadioButtonResult VKDB;
        [DisplayedName("Анемия тяжелой степени")] public NoYesRadioButtonResult SevereAnemia;
        [DisplayedName("Гипербилирубинемия")] public NoYesRadioButtonResult Hyperbilirubinemia;
        [DisplayedName("ЯНЭК (Язвенно некротический энтероколит)")] public NoYesRadioButtonResult UNEC;
        [DisplayedName("ВПР (Врожденный порок развития)")] public string BirthDefect;
        [DisplayedName("Оперативное вмешательство")] public string Surgery;
        [DisplayedName("№ Истории болезни")] public string PatientHistory;
        
        public Patient
            (
            long id,
            string lastName,
            string firstName,
            string surName,
            DateTime birthDate,
            string address
            )
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            SurName = surName;
            BirthDate = birthDate;
            Address = address;
        }

        public Patient()
        {
        }

        public long GetId() => Id;
        public void SetId(long id) => Id = id;

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Replace(LastName + " " + FirstName + " " + SurName + " - " + BirthDate.ToShortDateString(), @"\s+", " ");
        }
    }
}
