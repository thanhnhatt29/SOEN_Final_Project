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
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace UI
{
    public partial class OrderManage : Form
    {

        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string str = "Data Source=LAPTOP-0460STTB;Initial Catalog=FASTFOOD;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public OrderManage()
        {
            InitializeComponent();
            
        }

        public void Load_Image()
        {
            command = connection.CreateCommand();
            command.CommandText = "select count(product_id) from PRODUCT";
            int total_product = Convert.ToInt32(command.ExecuteScalar());
            for (int i = 1; i <= total_product; i++)
            {
                Button new_button = new Button();
                new_button.Height = 125;
                new_button.Width = 125;
                string path = System.IO.Directory.GetCurrentDirectory();
                path = path.Replace("\\UI\\bin\\Debug", "\\images\\product_id_product.jpg");
                path = path.Replace("id_product", i.ToString());
                new_button.BackgroundImage = Image.FromFile(path);
                new_button.BackgroundImageLayout = ImageLayout.Stretch;
                flowLayoutPanel1.Controls.Add(new_button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OrderManage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Load_Image();
        }
    }
}
