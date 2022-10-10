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
using BLL;
using System.IO.Ports;
using System.Collections;
using static System.Resources.ResXFileRef;

namespace UI
{
    public partial class OrderManage : Form
    {

        OrderBLL order_BLL = new OrderBLL();
        ListToDataTable converter = new ListToDataTable();
        List<BILL_LIST> bill_list = new List<BILL_LIST>();

        public OrderManage()
        {
            InitializeComponent();
            
        }

        public void Load_Image(List<PRODUCT> dt)
        {
            foreach (var item in dt)
            {
                Button new_button = new Button();
                new_button.Height = 125;
                new_button.Width = 125;

                new_button.Text = item.product_name.ToString();
                new_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

                string path = System.IO.Directory.GetCurrentDirectory();
                path = path.Replace("\\UI\\bin\\Debug", "\\images\\product_id_product.jpg");
                path = path.Replace("id_product", item.product_id.ToString());

                Image food_image = Image.FromFile(path);
                food_image = (Image)(new Bitmap(food_image, new Size(125, 100)));
                new_button.BackgroundImage = food_image;
                new_button.BackgroundImageLayout = ImageLayout.None;
                flowLayoutPanel1.Controls.Add(new_button);

                new_button.Click += (sender, args) =>
                {
                    if (bt_addProduct.Enabled == false)
                    {
                        bt_addProduct.Enabled = true;
                        bt_deleteProduct.Enabled = true;
                    }
                    lb_productID.Text = item.product_id.ToString();
                    lb_productName.Text = item.product_name.ToString();
                    lb_productPrice.Text = item.price.ToString();
                };
            }
        }

        private void OrderManage_Load(object sender, EventArgs e)
        {
            List<PRODUCT> product_list = new List<PRODUCT>();
            product_list = order_BLL.GetDataProduct();
            bt_addProduct.Enabled = false;
            bt_deleteProduct.Enabled = false;

            lb_productID.Text = "";
            lb_productName.Text = "";
            lb_billID.Text = "";
            lb_totalAmount.Text = "";
            Load_Image(product_list);

            ListToDataTable converter = new ListToDataTable();
            LoadData();
        }

        private void bt_addProduct_Click(object sender, EventArgs e)
        {
            BILL_LIST temp = new BILL_LIST();
            if (bill_list.Exists(x => x.ID == lb_productID.Text) == true)
            {
                int index = bill_list.FindIndex(x => x.ID == lb_productID.Text);
                if (index != -1)
                    bill_list[index].Amount = bill_list[index].Amount + 1;
            }
            else
            {
                temp.ID = lb_productID.Text;
                temp.Product = lb_productName.Text;
                temp.Price = Int32.Parse(lb_productPrice.Text);
                temp.Amount = 1;
                bill_list.Add(temp);
            }
            LoadData();
        }

        private void bt_deleteProduct_Click(object sender, EventArgs e)
        {
            
            BILL_LIST temp = new BILL_LIST();
            if (bill_list.Exists(x => x.ID == lb_productID.Text) == true)
            {
                int index = bill_list.FindIndex(x => x.ID == lb_productID.Text);
                if (index != -1 & bill_list[index].Amount > 1)
                {
                    bill_list[index].Amount = bill_list[index].Amount - 1;
                }
                else
                {
                    bill_list.RemoveAt(index);
                }
            }
            LoadData();
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

        private void bt_cancelBill_Click(object sender, EventArgs e)
        {
            bill_list.Clear();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = converter.ToDataTable(bill_list);
            dataGridView_bill.DataSource = dt;
            lb_totalPrice.Text = order_BLL.TotalBillPrice(bill_list).ToString();
            lb_totalAmount.Text = order_BLL.TotalProductAmount(bill_list).ToString();
        }

        private void bt_checkVoucher_Click(object sender, EventArgs e)
        {

        }
    }
}
