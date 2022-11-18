using DAL;
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


namespace UI
{
    public partial class BillDetail : Form
    {
        BillDetailDAL billdetail_DAL = new BillDetailDAL();
        ListToDataTable converter = new ListToDataTable();

        public string bill_id;
        public BillDetail()
        {
            InitializeComponent();
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            label2.Text = bill_id;
            List<BILL_DETAIL> bill_detail = new List<BILL_DETAIL>();
            bill_detail = billdetail_DAL.searchbilldetail(bill_id);
            DataTable dt = converter.ToDataTable(bill_detail);
            dt.Columns.Add("productname", typeof(System.String));
            foreach (DataRow row in dt.Rows)
            {
                row["productname"] = billdetail_DAL.getproductname(row["product_id"].ToString());
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã món ăn";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Tên món ăn";
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
    }
}
