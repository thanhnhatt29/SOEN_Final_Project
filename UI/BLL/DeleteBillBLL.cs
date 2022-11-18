using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeleteBillBLL
    {
        DeleteBillDAL deleteBillDAL = new DeleteBillDAL();
        
        public List<BILL> getDataBillDAL()
        {
            return deleteBillDAL.getDataBillDAL();
        }

        public List<BILL_DETAIL> getDataBillDetailDAL()
        {
            return deleteBillDAL.getDataBillDetailDAL();
        }

        public bool deleteBillByIdDAL(string bill_id)
        {
            return deleteBillDAL.deleteBillByIdDAL(bill_id);
        }

        public List<BILL> getDataBillDetailById(string bill_id)
        {
            return deleteBillDAL.getDataBillDetailById(bill_id);
        }

        public List<BILL> getDataBillDetailByDay()
        {
            return deleteBillDAL.getDataBillDetailByDay();
        }

        public List<BILL> getDataBillDetailByMonth()
        {
            return deleteBillDAL.getDataBillDetailByMonth();
        }

        public List<BILL> getDataBillDetailByWeek()
        {
            return deleteBillDAL.getDataBillDetailByWeek();
        }
    }
}
