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

        public int TotalBillPrice(List<BILL_LIST> dt)
        {
            int total = 0;
            foreach (var item in dt)
            {
                total = total + (item.Price * item.Amount);
            }
            return total;
        }

        public int TotalProductAmount(List<BILL_LIST> dt)
        {
            int total = 0;
            foreach (var item in dt)
            {
                total = total + item.Amount;
            }
            return total;
        }

        public int CheckVoucher ()
        {
            return 0;
        }
    }
}
