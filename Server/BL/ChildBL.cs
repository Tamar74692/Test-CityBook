using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class ChildBL
    {
        FormCBContext db = new FormCBContext();
        Conversions con = new Conversions();

        public void AddChild(ChildDTO child)
        {
            db.child.Add(con.GetChildFromDTO(child));
        }
    }
}
