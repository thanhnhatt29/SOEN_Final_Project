using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class RevenueBLL
    {
        BillDAL billDAL = new BillDAL();
        public DataTable getDataDate()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ngày");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();
            var data = list.GroupBy(g=>g.date_created.Date)
                            .Select(x => new { Date=x.Key.Date.ToString("dd-MM-yyyy"), Money=x.Sum(y=>y.total_money), realDate = x.Key}).OrderBy(x=>x.realDate);
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Date,item.Money);
            }
            
            return dataTable;
        }

        public DataTable getDataMonth()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();
            /*var data = from t in list 
                       group t by new { Year = t.date_created.Year,Month=t.date_created.Month} 
                       into g
                             select new { MonthYear = (g.Key.Year+"/"+g.Key.Month), Money = g.Sum(y => y.total_money) };*/
            var data = list.GroupBy(g => new { g.date_created.Year,g.date_created.Month })
                            .Select(x => new { MonthYear = (x.Key.Month + "-" + x.Key.Year), Money = x.Sum(y => y.total_money),Month = x.Key.Month,Year = x.Key.Year }).OrderBy(x=>x.Year).OrderBy(x=>x.Month);
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.MonthYear, item.Money);
            }
            
            return dataTable;
        }

        public DataTable getDataYear()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Năm");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();
            var data = list.GroupBy(g => g.date_created.Year)
                            .Select(x => new { Date = x.Key, Money = x.Sum(y => y.total_money) }).OrderBy(x=>x.Date);
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Date, item.Money);
            }

            return dataTable;
        }

        public DataTable getDateSales(string date)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ngày");
            dataTable.Columns.Add("Nhân viên");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();
            var data = list.GroupBy(g => new { Date = g.date_created.Date,Emp = g.employee_id })
                            .Select(x => new { Date = x.Key.Date.ToString("dd-MM-yyyy"), Money = x.Sum(y => y.total_money), Emp = x.Key.Emp });
            //var data_date = data.Where(x=>x.Date==date).Select(x=>x);
            foreach (var item in data)
            {
                if(item.Date == date)
                    dataTable.Rows.Add(item.Date, item.Emp, item.Money);
            }

            return dataTable;
        }

        public DataTable getMonthSales(string date)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng");
            dataTable.Columns.Add("Nhân viên");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();
            var data = list.GroupBy(g => new { g.date_created.Year, g.date_created.Month,Emp = g.employee_id })
                           .Select(x => new { MonthYear = (x.Key.Month + "-" + x.Key.Year), Money = x.Sum(y => y.total_money), Month = x.Key.Month, Year = x.Key.Year, Emp = x.Key.Emp }).OrderBy(x => x.Year).OrderBy(x => x.Month);

            foreach (var item in data)
            {
                if (item.MonthYear == date)
                    dataTable.Rows.Add(item.MonthYear, item.Emp, item.Money);
            }

            return dataTable;
        }

        public DataTable getYearSales(string date)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Năm");
            dataTable.Columns.Add("Nhân viên");
            dataTable.Columns.Add("Tiền");
            List<BILL> list = billDAL.getDataBillDAL();

            var data = list.GroupBy(g => new { Year = g.date_created.Year, Emp = g.employee_id})
                            .Select(x => new { Date = x.Key.Year.ToString(), Emp = x.Key.Emp, Money = x.Sum(y => y.total_money) });

            foreach (var item in data)
            {
                if (item.Date == date)
                    dataTable.Rows.Add(item.Date, item.Emp, item.Money);
            }
            return dataTable;
        }
    }
}
