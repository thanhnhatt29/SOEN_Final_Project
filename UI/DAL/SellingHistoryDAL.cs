using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellingHistoryDAL
    {
        public List<BILL> getDataSellingDAL()
        {
            List<BILL> data = new List<BILL>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.BILLs
                            select c;
                foreach (var bill in table)
                {
                    data.Add(bill);
                }
                return data;
            }
        }

        public List<BILL> searchbill(string bill_id)
        {
            List<BILL> list = getDataSellingDAL();
            List<BILL> billlist = new List<BILL>();
            foreach (var p in list)
            {
                if (p.bill_id.ToLower().TrimEnd().Contains(bill_id.ToLower()))
                {
                    billlist.Add(p);
                }
            }
            return billlist;
        }
    }
}
