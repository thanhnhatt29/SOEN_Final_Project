using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        public List<EMPLOYEE> getDataEmpDAL()
        {
            List<EMPLOYEE> data = new List<EMPLOYEE>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.EMPLOYEEs
                            select c;
                foreach(var emp in table)
                {
                    data.Add(emp);
                }    
                return data;
            }    
        }
    }
}
