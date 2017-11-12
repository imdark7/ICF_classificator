using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        [DisplayedName("Гестационный возраст")] public int GestationAge;
        [DisplayedName("Масса тела при рождении")] public int BirthWeight;
        [DisplayedName("Длина при рождении")] public int BirthHeight;
        [DisplayedName("Окружность головы при рождении")] public int BirthHeadSize;
        [DisplayedName("Окружность грудной клетки при рождении")] public int BirthChestSize;
        [DisplayedName("Оценка по Апгар")] public ApgarResult ApgarScale;
        [DisplayedName("Инвалидность")] public NoYesRadioButtonResult HasDisability;
        [DisplayedName("Госпитализация")] public HospitalizationCount IsNotFirstHospitalization;
        [DisplayedName("Дата поступления")] public DateTime HospitalizationDate;
        /// <summary>
        /// Искусственная вентиляция легких
        /// </summary>
        [DisplayedName("ИВЛ")] public int ALVDuration;
        [DisplayedName("CPAP")] public int CPAPDuration;
        [DisplayedName("Церебральная ишемия")] public CerebralIschemiaDegree CerebralIschemia;
        /// <summary>
        /// Внутрижелудочковое кровотечение
        /// </summary>
        [DisplayedName("ВЖК")] public IVHModel IVH;
        [DisplayedName("Менингит")] public NoYesRadioButtonResult Meningitis;
        [DisplayedName("Энцефалит")] public NoYesRadioButtonResult Encephalitis;
        /// <summary>
        /// Судорожный синдром
        /// </summary>
        [DisplayedName("Судорожный синдром")] public int ConvulsiveSyndromeDuration;
        [DisplayedName("Сепсис")] public NoYesRadioButtonResult Sepsis;
        /// <summary>
        /// Гемолитическая болезнь новорожденных
        /// </summary>
        [DisplayedName("ГБН")] public NoYesRadioButtonResult HDN;
        /// <summary>
        /// Геморрагический синдром
        /// </summary>
        [DisplayedName("Геморрагический синдром")] public NoYesRadioButtonResult VKDB;
        [DisplayedName("Анемия тяжелой степени")] public NoYesRadioButtonResult Anemia;
        [DisplayedName("Гипербилирубинемия")] public NoYesRadioButtonResult Hyperbilirubinemia;
        /// <summary>
        /// Язвенно-некротический энтероколит
        /// </summary>
        [DisplayedName("ЯНЭК")] public NoYesRadioButtonResult UNEC;
        /// <summary>
        /// Врожденный порок развития
        /// </summary>
        [DisplayedName("ВПР")] public string BirthDefect;
        [DisplayedName("Оперативное вмешательство")] public string Surgery;
        [DisplayedName("№ Историй болезни")] public string PatientHistory;
        
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

        public string GetFullNameAndBirthDate()
        {
            return System.Text.RegularExpressions.Regex.Replace(LastName + " " + FirstName + " " + SurName + " - " + BirthDate.ToShortDateString(), @"\s+", " ");
        }

        public string GetFullName()
        {
            return System.Text.RegularExpressions.Regex.Replace(LastName + " " + FirstName + " " + SurName, @"\s+", " ");
        }

        public FieldInfo GetFieldInfo(string fieldName)
        {
            return (from field in typeof(Patient).GetFields() where field.Name == fieldName select field).First();
        }

        public static List<FieldInfo> GetFieldInfos()
        {
            return typeof(Patient).GetFields().ToList();
        }
    }
}
