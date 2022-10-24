using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class OrderBLL
    {
        OrderDAL order_DAL = new OrderDAL();
        public List<PRODUCT> GetDataProduct()
        {
            return order_DAL.getDataProduct();
        }

        public int TotalBillPrice(List<BILL_LIST> dt)
        {
            return order_DAL.TotalBillPrice(dt);
        }

        public int TotalProductAmount(List<BILL_LIST> dt)
        {
            return order_DAL.TotalProductAmount(dt);
        }

        public VOUCHER CheckVoucher(string voucher_key)
        {
            return order_DAL.CheckVoucher(voucher_key);
        }

        public bool AddBillDetail(String bill_id, DataTable bill_list)
        {
            return order_DAL.AddBillDetail(bill_id, bill_list);
        }

        public bool ChechNewBillID(string BillID)
        {
            return order_DAL.ChechNewBillID(BillID);
        }

        public string randID()
        {
            var chars = "0123456789";
            Random random = new Random();
            string ID = "";
            for (int i = 0; i < 4; i++)
            {
                char rand = chars[random.Next(0, chars.Length)];
                ID += rand;
            }
            return ID;
        }

        public bool AddBill(String bill_id, String employee_id, String voucher_id, int total_price, int off_price, int final_money)
        {
            return order_DAL.AddBill(bill_id, employee_id, voucher_id, total_price, off_price, final_money);
        }
    }
}
