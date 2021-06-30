using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class PersonBL
    {
        FormCBContext db = new FormCBContext();
        Conversions con = new Conversions();

        public void AddPerson(PersonDTO person)
        {
            
            db.person.Add(con.GetPersonFromDTO(person));
        }
       
    }
}
