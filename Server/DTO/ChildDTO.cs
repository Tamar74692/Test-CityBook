using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChildDTO
    {
        public int Identity { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ID { get; set; }
        ////public virtual PersonDTO Person { get; set; }
    }
}
