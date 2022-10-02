using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDetailDAL
    {
        public List<BILL_DETAIL> getDataBillDetailDAL()
        {
            List<BILL_DETAIL> data = new List<BILL_DETAIL>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.BILL_DETAIL
                            select c;
                foreach (var billdetail in table)
                {
                    data.Add(billdetail);
                }
                return data;
            }
        }

        public bool updateBillDetailDAL(string bill_id, int product_id, int amount)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.BILL_DETAIL
                            select c;

                foreach(var t in table)
                {
                    if(t.bill_id == bill_id)
                    {
                        t.product_id = product_id;
                        t.amount = amount;
                    }
                }
                db.SaveChanges();
                return true;
            }
        }

        public bool addBillDetailDAL(string bill_id, int product_id, int amount)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                BILL_DETAIL bill_detail = new BILL_DETAIL();

                bill_detail.bill_id = bill_id;
                bill_detail.product_id = product_id;
                bill_detail.amount = amount;

                db.BILL_DETAIL.Add(bill_detail);
                db.SaveChanges();
                return true;
            }
        }
    }
}
