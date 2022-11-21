using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
namespace UI
{
    public partial class RevenueManage : Form
    {
        


        RevenueBLL revenueBLL = new RevenueBLL();
        public RevenueManage()
        {
            InitializeComponent();
            //dataRevenue.DataSource = revenueBLL.getDataDate();
            //dataRevenue.DataSource = revenueBLL.getDataMonth();
            dataRevenue.DataSource = revenueBLL.getDataDate();
            dataRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevenue.ReadOnly = true;
            comboBox1.SelectedIndex = 0;
            chartBoard("Ngày");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Ngày")
            {
                dataRevenue.DataSource = revenueBLL.getDataDate();
                chartBoard(comboBox1.Text);
                pieBoard(0, 0);
            }
            else if(comboBox1.Text == "Tháng")
            {
                dataRevenue.DataSource=revenueBLL.getDataMonth();
                chartBoard(comboBox1.Text);
                pieBoard(0, 0);
            }
            else if(comboBox1.Text == "Năm")
            {
                dataRevenue.DataSource = revenueBLL.getDataYear();
                chartBoard(comboBox1.Text);
                pieBoard(0, 0);
            }
            
        }

        private void chartBoard(string elem)
        {
            chart1.Series["Doanh thu"].XValueMember = elem;
            chart1.Series["Doanh thu"].YValueMembers = "Tiền";
            chart1.Series["Tăng trưởng"].XValueMember= elem;
            chart1.Series["Tăng trưởng"].YValueMembers = "Tiền";
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh thu của quán theo từng " + elem.ToLower());
            chart1.DataSource = dataRevenue.DataSource;
            chart1.DataBind();
        }

        private DateTime getDate(string date)
        {
            return DateTime.ParseExact(date, "dd-MM-YY",System.Globalization.CultureInfo.InvariantCulture);   
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pieBoard(int rows, int cols)
        {
            string date = dataRevenue.Rows[rows].Cells[cols].Value.ToString();
            DataTable dt = new DataTable();
            if (comboBox1.Text == "Ngày")
            {
                dt = revenueBLL.getDateSales(date);
            }
            else if (comboBox1.Text == "Tháng")
            {
                dt = revenueBLL.getMonthSales(date);
            }
            else if (comboBox1.Text == "Năm")
            {
                dt = revenueBLL.getYearSales(date);
            }
            //DataTable dt = revenueBLL.getDateSales(date);

            chart2.Titles.Clear();
            chart2.Series["Percent"].Points.Clear();
            chart2.Titles.Add("Tỉ lệ ở "+comboBox1.Text.ToLower()+" "+date);
            foreach (DataRow row in dt.Rows)
            {
                chart2.Series["Percent"].Points.AddXY(row[1], row[2]);
            }
        }


        private void dataRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pieBoard(e.RowIndex, 0);
        }
    }
}
