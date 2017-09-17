using System;

namespace ICF_classificator.Models
{
    public class Patient
    {
        public int Id;
        public string LastName;
        public string FirstName;
        public string SurName;
        public DateTime BirthDate;
        public int? DoctorId;

        public Patient(int id, string lastName, string firstName, string surName, DateTime birthDate, int doctorId)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            SurName = surName;
            BirthDate = birthDate;
            DoctorId = doctorId;
        }

        public Patient()
        {
        }

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Replace(LastName + " " + FirstName + " " + SurName, @"\s+", " ");
        }
    }
}
