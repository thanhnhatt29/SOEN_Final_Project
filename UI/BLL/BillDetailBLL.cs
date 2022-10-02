using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BillDetailBLL
    {
        BillDetailDAL bill_DAL = new BillDetailDAL();

        public List<BILL_DETAIL> getDataBillDetailBLL()
        {
            return bill_DAL.getDataBillDetailDAL();
        }

        public string addBillDetailBLL(string bill_id, int product_id, int amount)
        {
            if (bill_DAL.addBillDetailDAL(bill_id, product_id, amount))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public string updateBillDetailBLL(string bill_id, int product_id, int amount)
        {
            if (bill_DAL.updateBillDetailDAL(bill_id, product_id, amount))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

    }
}
