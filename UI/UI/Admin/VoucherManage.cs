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


namespace UI
{
    public partial class VoucherManage : Form
    {
        SqlConnection connection=new SqlConnection();
        
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
            command = connection.CreateCommand();
            command.CommandText = "insert into VOUCHER values('" + voucher.Text + "','" + price.Text + "','" + percent.Text + "','" + money.Text + "','" + comboBox1.Text + "')";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "select * from VOUCHER where voucher_id like('%" + textBox1.Text + "%')";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(command);
                a.Fill(dt);
                int i = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                if (i == 0)
                {
                    MessageBox.Show("No Found voucher!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update VOUCHER set apply_price = " + price.Text + " , off_percent = " + percent.Text + ", max_money = " + money.Text + " ,used='" + comboBox1.Text + "' where voucher_id='" + voucher.Text + "'";
                command.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from VOUCHER where voucher_id='" + voucher.Text + "'";
                command.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
    }
}
