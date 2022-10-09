using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class BillBLL
    {
        BillDAL bill_DAL = new BillDAL();
        public List<BILL> getDataBillDLL()
        {
            return bill_DAL.getDataBillDAL();
        }

        public string addBillBLL(string bill_id, DateTime date_created, string employee_id, string voucher_id, int bill_price, int off_money)
        {
            if (!checkBillPrice(bill_price, off_money))
            {
                return "Giá bị sai";
            }
            if (bill_DAL.addBillDAL(bill_id, date_created, employee_id, voucher_id, bill_price, off_money))
            {
                return "Thành công";
            }
            else
                return "Thất bại";
        }

        public string updateBillBLL(string bill_id, DateTime date_created, string employee_id, string voucher_id, int bill_price, int off_money)
        {
            if (bill_DAL.updateBillDAL(bill_id, date_created, employee_id, voucher_id, bill_price, off_money))
            {
                return "Thành công";
            }
            else
                return "Thất bại";
        }

        bool checkBillPrice(int bill_price, int off_money)
        {
            if (bill_price < 0)
            {
                return false;
            }
            if (off_money < 0)
            {
                return false;
            }
            return true;
        }
    }
}
