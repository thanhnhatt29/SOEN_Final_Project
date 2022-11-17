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
        /*SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0460STTB;Initial Catalog=FASTFOOD;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public RevenueManage()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BILL";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }*/


        RevenueBLL revenueBLL = new RevenueBLL();
        public RevenueManage()
        {
            InitializeComponent();
            //dataRevenue.DataSource = revenueBLL.getDataDate();
            //dataRevenue.DataSource = revenueBLL.getDataMonth();
            dataRevenue.DataSource = revenueBLL.getDataDate();
            dataRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRevenue.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Ngày")
            {
                dataRevenue.DataSource = revenueBLL.getDataDate();
            }
            else if(comboBox1.Text == "Tháng")
            {
                dataRevenue.DataSource=revenueBLL.getDataMonth();
            }
            else if(comboBox1.Text == "Năm")
            {
                dataRevenue.DataSource = revenueBLL.getDataYear();
            }
        }
    }
}
