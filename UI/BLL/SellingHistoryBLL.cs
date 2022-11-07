using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SellingHistoryBLL
    {
        SellingHistoryDAL sellhistoryDAL = new SellingHistoryDAL();

        public List<BILL> getDataSellingBLL()
        {
            return sellhistoryDAL.getDataSellingDAL();
        }

        public List<BILL> searchbill(string bill_id)
        {
            return sellhistoryDAL.searchbill(bill_id);
        }
    }
}
