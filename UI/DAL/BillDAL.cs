using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        public List<BILL> getDataBillDAL()
        {
            List<BILL> data = new List<BILL>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.BILLs
                          select c;
                foreach(var bill in table)
                {
                    data.Add(bill);
                }
                return data;
            }
        }

        public bool updateBillDAL(string bill_id, DateTime date_created, string employee_id, string voucher_id, int bill_price, int off_money)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.BILLs
                            select c;
                foreach (var t in table)
                {
                    if (t.bill_id == bill_id)
                    {
                        t.date_created = date_created;
                        t.employee_id = employee_id;
                        t.voucher_id = voucher_id;
                        t.bill_price = bill_price;
                        t.off_money = off_money;
                    }
                }
                db.SaveChanges();
                return true;
            }
        }

        public bool addBillDAL(string bill_id, DateTime date_created, string employee_id, string voucher_id, int bill_price, int off_money)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                BILL bill = new BILL();

                bill.bill_id = bill_id;
                bill.date_created = date_created;
                bill.employee_id = employee_id;
                bill.voucher_id = voucher_id;
                bill.bill_price = bill_price;
                bill.off_money = off_money;

                db.BILLs.Add(bill);
                db.SaveChanges();
                return true;
            }
        }
    }
}
