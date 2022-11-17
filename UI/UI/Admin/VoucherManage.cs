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
    public partial class VoucherManage : Form
    {
        List<DAL.VOUCHER> vouchersList = new List<DAL.VOUCHER>();
        VoucherBLL voucherBLL = new VoucherBLL();
        public VoucherManage()
        {
            InitializeComponent();
            LoadData();
        }

        #region
        void LoadData()
        {
            clearDataBinding();
            getData();
            addDataBinding();
            headerChange();
        }

        void getData()
        {
            vouchersList = voucherBLL.getDataVoucherBLL();
            dataVoucher.DataSource = vouchersList;

        }

        void clearDataBinding()
        {
            voucherId_Box.DataBindings.Clear();
            price_Box.DataBindings.Clear();
            money_Box.DataBindings.Clear();
            percent_Box.DataBindings.Clear();
            used_Box.DataBindings.Clear();
        }
        void addDataBinding()
        {
            voucherId_Box.DataBindings.Add(new Binding("Text", dataVoucher.DataSource, "voucher_id",true,DataSourceUpdateMode.Never));
            price_Box.DataBindings.Add(new Binding("Text", dataVoucher.DataSource, "apply_price", true, DataSourceUpdateMode.Never));
            money_Box.DataBindings.Add(new Binding("Text", dataVoucher.DataSource, "max_money", true, DataSourceUpdateMode.Never));
            percent_Box.DataBindings.Add(new Binding("Text", dataVoucher.DataSource, "off_percent", true, DataSourceUpdateMode.Never));
            used_Box.DataBindings.Add(new Binding("Text", dataVoucher.DataSource, "used", true, DataSourceUpdateMode.Never));
        }
        void headerChange()
        {
            dataVoucher.Columns[0].HeaderText = "Mã giảm giá";
            dataVoucher.Columns[1].HeaderText = "Giá áp dụng";
            dataVoucher.Columns[2].HeaderText = "Phần trăm";
            dataVoucher.Columns[3].HeaderText = "Không thể dùng";
            dataVoucher.Columns[4].HeaderText = "Tiền tối đa";
            dataVoucher.Columns[3].Visible = false;  
        }

        void getValues()
        {
            id = voucherId_Box.Text.Trim();
            price = price_Box.Text.Trim();
            percent = percent_Box.Text.Trim();
            money = money_Box.Text.Trim();
        }
        #endregion

        string id;
        string price;
        string money;
        string percent;

        private void add_Button_Click(object sender, EventArgs e)
        {
            getValues();
            
            try
            {

                MessageBox.Show(voucherBLL.addVoucherBLL(id, price, percent, money));
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            LoadData();
            
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            getValues();
            
            try
            {

                MessageBox.Show(voucherBLL.updateVoucherBLL(id, price, percent, money, used_Box.Text));
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            LoadData();
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            getValues();
            
            try
            {
                if (voucherBLL.delVoucherBLL(id))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
                
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            LoadData();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            vouchersList = voucherBLL.searchVoucher(searchBox.Text);
            dataVoucher.DataSource=vouchersList;
            clearDataBinding();
            addDataBinding();
        }


        /*   SqlConnection connection =new SqlConnection();

SqlCommand command;
string str = "Data Source=.\\SQLEXPRESS;Initial Catalog=FASTFOOD;Integrated Security=True";
SqlDataAdapter da = new SqlDataAdapter();
DataTable dt = new DataTable();

public VoucherManage()
{
InitializeComponent();
}

public void LoadData()
{
command = connection.CreateCommand();
command.CommandText = "select * from VOUCHER";
da.SelectCommand = command;
dt.Clear();
da.Fill(dt);
dataGridView1.DataSource = dt;
}

private void button1_Click(object sender, EventArgs e)
{

}

private void button6_Click(object sender, EventArgs e)
{

}

private void button4_Click(object sender, EventArgs e)
{

}

private void button3_Click(object sender, EventArgs e)
{

}

private void button5_Click(object sender, EventArgs e)
{
this.Hide();
}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
// voucher.ReadOnly = true;
int i;
i = dataGridView1.CurrentRow.Index;
voucher.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
price.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
percent.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
money.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
comboBox1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
}

private void VoucherManage_Load(object sender, EventArgs e)
{

}


*/

    }
}
