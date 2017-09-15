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

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + SurName;
        }
    }
}
