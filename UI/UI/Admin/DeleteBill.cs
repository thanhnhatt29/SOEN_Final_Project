using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace UI
{
    public partial class DeleteBill : Form
    {
        DeleteBillBLL deleteBillBLL = new DeleteBillBLL();
        ListToDataTable converter = new ListToDataTable();

        public DeleteBill()
        {
            InitializeComponent();
        }

        private void bt_deleteByName_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_deleteByDay_Click(object sender, EventArgs e)
        {
            List<BILL> bill = new List<BILL>();
            bill = deleteBillBLL.getDataBillDetailByDay();
            DataTable dt = converter.ToDataTable(bill);
            dataGridView1.DataSource = dt;
        }

        private void bt_deleteByWeek_Click(object sender, EventArgs e)
        {
            List<BILL> bill = new List<BILL>();
            bill = deleteBillBLL.getDataBillDetailByWeek();
            DataTable dt = converter.ToDataTable(bill);
            dataGridView1.DataSource = dt;
        }

        private void bt_deleteByMonth_Click(object sender, EventArgs e)
        {
            List<BILL> bill = new List<BILL>();
            bill = deleteBillBLL.getDataBillDetailByMonth();
            DataTable dt = converter.ToDataTable(bill);
            dataGridView1.DataSource = dt;
        }

        public class ListToDataTable
        {
            public DataTable ToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
        }

        private void bt_deleteDataInTable_Click(object sender, EventArgs e)
        {

        }
    }
}
