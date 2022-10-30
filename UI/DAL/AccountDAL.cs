using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        public List<ACCOUNT> getDataAccDAL()
        {
            List<ACCOUNT> data = new List<ACCOUNT>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.ACCOUNTs
                            select c;
                foreach(var acc in table)
                {
                    data.Add(acc);
                }    
                return data;
            }    
        }

        public ACCOUNT loginDAL(string name)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var acc = from c in db.ACCOUNTs
                          where c.employee_id == name
                          select c;
                foreach (var a in acc)
                {
                   return a;
                }    
                return null;
            }
          
        }
    }
}
