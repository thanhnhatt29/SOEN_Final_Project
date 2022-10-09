using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        public List<PRODUCT> getDataProduct()
        {
            List<PRODUCT> dt = new List<PRODUCT>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.PRODUCTs
                            select c;
                foreach(var product in table)
                {
                    dt.Add(product);
                }    
                return dt;
            }
        }
    }
}
