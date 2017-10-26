﻿using System;
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
        [DisplayedName("Масса тела при рождении)")] public int WeightNewborn;
        [DisplayedName("Длина при рождении")] public int HeightNewborn;
        [DisplayedName("Окружность головы при рождении")] public int HeadSizeNewborn;
        [DisplayedName("Окружность грудной клетки при рождении")] public int ChestSizeNewborn;
        [DisplayedName("Оценка по Апгар")] public ApgarResult ApgarScale;
        [DisplayedName("Инвалидность")] public NoYesRadioButtonResult Disability;
        [DisplayedName("Госпитализация")] public HospitalizationCount Hospitalization;
        [DisplayedName("Дата поступления")] public DateTime HospitalizationDate;
        [DisplayedName("ИВЛ")] public int ALVDuration;
        [DisplayedName("CPAP")] public int CPAPDuration;
        [DisplayedName("Церебральная ишемия")] public CerebralIschemiaDegree CerebralIschemia;
        [DisplayedName("ВЖК")] public IVHModel IVH;
        [DisplayedName("Менингит")] public NoYesRadioButtonResult Meningitis;
        [DisplayedName("Энцефалит")] public NoYesRadioButtonResult Encephalitis;
        [DisplayedName("Судорожный синдром")] public int ConvulsiveSyndromeDuration;
        [DisplayedName("Сепсис")] public NoYesRadioButtonResult Sepsis;
        [DisplayedName("ГБН")] public NoYesRadioButtonResult HDN;
        [DisplayedName("Геморрагический синдром")] public NoYesRadioButtonResult VKDB;
        [DisplayedName("Анемия тяжелой степени")] public NoYesRadioButtonResult SevereAnemia;
        [DisplayedName("Гипербилирубинемия")] public NoYesRadioButtonResult Hyperbilirubinemia;
        [DisplayedName("ЯНЭК")] public NoYesRadioButtonResult UNEC;
        [DisplayedName("ВПР")] public string BirthDefect;
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
