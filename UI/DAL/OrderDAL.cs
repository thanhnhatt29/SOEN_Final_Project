using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

        public VOUCHER CheckVoucher (string voucher_key)
        {
            List<VOUCHER> dt = new List<VOUCHER>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.VOUCHERs
                            select c;
                foreach (var voucher in table)
                {
                    dt.Add((voucher));
                }
            }
            foreach (var voucher in dt)
            {
                if (voucher.voucher_id.TrimEnd().Equals(voucher_key))
                {
                    return voucher;
                }
            }
            return null;
        }

        public bool AddBillDetail(String bill_id, DataTable bill_list)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                foreach (DataRow dr in bill_list.Rows)
                {
                    BILL_DETAIL bill = new BILL_DETAIL();
                    bill.bill_id = bill_id;
                    bill.product_id = Convert.ToInt32(dr[0]);
                    bill.amount = Convert.ToInt32(dr[3]);
                    try
                    {
                        db.BILL_DETAIL.Add(bill);
                        db.SaveChanges();
                    }
                    catch
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool ChechNewBillID(string BillID)
        {
            List<BILL> dt = new List<BILL>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var idtable = from c in db.BILLs
                              where c.bill_id == BillID
                              select c;
                if (idtable == null || idtable.Count() == 0) return true;
                return false;
            }
        }

        public bool AddBill(String bill_id, String employee_id, String voucher_id, int total_price, int off_price, int final_money)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {      
                BILL bill = new BILL();
                bill.bill_id = bill_id;
                bill.date_created = DateTime.Now;
                bill.employee_id = employee_id;
                bill.voucher_id = voucher_id;
                bill.bill_price = total_price;
                bill.off_money = off_price;
                bill.total_money = final_money;
                try
                {
                    db.BILLs.Add(bill);
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

    }
}
