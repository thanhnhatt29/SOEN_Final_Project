using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeleteBillDAL
    {
        public List<BILL> getDataBillDAL()
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

        public bool deleteBillByIdDAL(string bill_id)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                db.BILL_DETAIL.Remove(db.BILL_DETAIL.Where(p => p.bill_id == bill_id).SingleOrDefault());
                db.SaveChanges();
            }
            return true;
        }

        public List<BILL> getDataBillDetailById(string bill_id)
        {
            List<BILL> list = getDataBillDAL();
            List<BILL> billlist = new List<BILL>();
            foreach (var p in list)
            {
                if (p.bill_id.ToLower().TrimEnd().Equals(bill_id.ToLower()))
                {
                    billlist.Add(p);
                }
            }
            return billlist;
        }

        public List<BILL> getDataBillDetailByDay()
        {
            List<BILL> list = getDataBillDAL();
            List<BILL> billdetaillist = new List<BILL>();
            DateTime datenow = DateTime.Now.Date;
            foreach (var p in list)
            {
                if (DateTime.Equals(p.date_created, datenow) != true)
                {
                    billdetaillist.Add(p);
                }
            }
            return billdetaillist;
        }

        public List<BILL> getDataBillDetailByMonth()
        {
            List<BILL> list = getDataBillDAL();
            List<BILL> billdetaillist = new List<BILL>();
            DateTime datenow = DateTime.Now.Date;
            foreach (var p in list)
            {
                if ((datenow-p.date_created).TotalDays > 30)
                {
                    billdetaillist.Add(p);
                }
            }
            return billdetaillist;
        }

        public List<BILL> getDataBillDetailByWeek()
        {
            List<BILL> list = getDataBillDAL();
            List<BILL> billdetaillist = new List<BILL>();
            DateTime datenow = DateTime.Now.Date;
            foreach (var p in list)
            {
                if ((datenow - p.date_created).TotalDays > 7)
                {
                    billdetaillist.Add(p);
                }
            }
            return billdetaillist;
        }
    }
}
