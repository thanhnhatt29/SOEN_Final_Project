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
                if (voucher.voucher_id.Equals(voucher_key))
                {
                    return voucher;
                }
            }
            return null;
        }

        public bool AddOrderBill(String bill_id, DataTable bill_list)
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
    }
}
