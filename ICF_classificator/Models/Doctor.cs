using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICF_classificator.Models
{
    public class Doctor
    {
        public int Id;
        public string LastName;
        public string FirstName;
        public string SurName;

        public Doctor(int Id, string LastName, string FirstName, string SurName)
        {
            this.Id = Id;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.SurName = SurName;
        }
    }
}
