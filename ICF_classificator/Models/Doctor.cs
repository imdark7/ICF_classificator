using static System.Text.RegularExpressions.Regex;

namespace ICF_classificator.Models
{
    public class Doctor
    {
        public int Id;
        public string LastName;
        public string FirstName;
        public string SurName;

        public Doctor(int id, string lastName, string firstName, string surName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            SurName = surName;
        }

        public Doctor()
        {
        }

        public override string ToString() => Replace(LastName + " " + FirstName + " " + SurName, @"\s+", " ");

        public string ToShortString() => Replace(LastName + " " + FirstName.Substring(0,1).ToUpper() + " " + SurName?.Substring(0, 1).ToUpper(), @"\s+", " ");
    }
}
