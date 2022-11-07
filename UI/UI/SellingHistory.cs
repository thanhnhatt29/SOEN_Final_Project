using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Reflection;
using static System.Resources.ResXFileRef;

namespace UI
{
    public partial class SellingHistory : Form
    {
        SellingHistoryBLL sellhistory = new SellingHistoryBLL();
        ListToDataTable converter = new ListToDataTable();
        List<BILL> bill_list = new List<BILL>();

        public SellingHistory()
        {
            InitializeComponent();
        }

        private void SellingHistory_Load(object sender, EventArgs e)
        {
            bill_list = sellhistory.getDataSellingBLL();
            DataTable dt = converter.ToDataTable(bill_list);
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

        private void button1_Click(object sender, EventArgs e)
        {
            bill_list = sellhistory.getDataSellingBLL();
            DataTable dt = converter.ToDataTable(bill_list);
            dataGridView1.DataSource = dt;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bill_list = sellhistory.searchbill(textBox1.Text);
            DataTable dt = converter.ToDataTable(bill_list);
            dataGridView1.DataSource = dt;
        }
    }
}
