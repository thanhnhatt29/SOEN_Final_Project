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
using System.IO;

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
            dt.Columns.Add("info", typeof(System.String));
            foreach (DataRow row in dt.Rows)
            {
                row["info"] = "Xem";
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Ngày tạo đơn";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Mã giảm giá";
            dataGridView1.Columns[4].HeaderText = "Giá đơn hàng";
            dataGridView1.Columns[5].HeaderText = "Tiền giảm giá";
            dataGridView1.Columns[6].HeaderText = "Tổng tiền";
            dataGridView1.Columns[7].HeaderText = "Chi tiết";
            dataGridView1.ReadOnly = true;
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

        private void bt_exportCSV_Click(object sender, EventArgs e)
        {
            bill_list = sellhistory.getDataSellingBLL();
            DataTable dt = converter.ToDataTable(bill_list);
            string path = "";
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = diag.SelectedPath + "SellHistory.csv";  //selected folder path

            }
            ToCSV(dt, path);
        }

        private void ToCSV(DataTable DT, string path)
        {
            try
            {
                // code block for writing headers of data table

                int columnCount = DT.Columns.Count;
                string columnNames = "";
                string[] output = new string[DT.Rows.Count + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DT.Columns[i].ToString() + ",";
                }
                output[0] += columnNames;

                // code block for writing rows of data table
                for (int i = 1; (i - 1) < DT.Rows.Count; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += DT.Rows[i - 1][j].ToString() + ",";
                    }
                }

                System.IO.File.WriteAllLines(path, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Đã tạo được file");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Không tạo được file");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.bill_id = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                billDetail.ShowDialog();
            }
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
