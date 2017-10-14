using System;

namespace ICF_classificator.Models
{
    public class Patient
    {
        public long Id;
        public string LastName;
        public string FirstName;
        public string SurName;
        public DateTime BirthDate;
        public long? DoctorId;
        public string Address;

        public Patient(long id, string lastName, string firstName, string surName, DateTime birthDate, long doctorId, string address)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            SurName = surName;
            BirthDate = birthDate;
            DoctorId = doctorId;
            Address = address;
        }

        public Patient()
        {
        }

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Replace(LastName + " " + FirstName + " " + SurName + " - " + BirthDate.ToShortDateString(), @"\s+", " ");
        }
    }
}
