namespace ICF_classificator.Models
{
    public class Derangement
    {
        public string Code;
        public string Name;
        public string Description;
        public string ParentCode;

        public Derangement(string code, string name, string description, string parentCode)
        {
            Code = code;
            Name = name;
            Description = description;
            ParentCode = parentCode;
        }
    }
}
