using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
    public class Person
    {
        public int Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string MaleOrFemale { get; set; }
        public string HMO { get; set; }

    }
}
