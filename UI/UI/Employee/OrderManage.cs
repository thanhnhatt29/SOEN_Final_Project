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
using System.Drawing.Printing;
using System.Runtime.Remoting.Messaging;
using System.Globalization;

namespace UI
{
    
    public partial class OrderManage : Form
    {
        Message message = new Message();
        
        OrderBLL order_BLL = new OrderBLL();
        ListToDataTable converter = new ListToDataTable();
        List<BILL_LIST> bill_list = new List<BILL_LIST>();
        public string billid;
        public string emp_id;
        private Font verdana10Font;
        private StreamReader reader;
        public string emp_phone;
        public string emp_name;

        public OrderManage()
        {
            InitializeComponent();
            
            
        }

        public void Load_Image(List<PRODUCT> productdata)
        {

            foreach (var item in productdata)
            {
                
                Button new_button = new Button();
                new_button.Height = 150;
                new_button.Width = 150;

                new_button.Text = item.product_name.ToString();
                new_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

                
                Image food_image = null;
                byte[] imageData = item.product_img;
                if (imageData != null)
                {
                    MemoryStream ms = new MemoryStream(imageData);
                    food_image = Image.FromStream(ms);
                }
                else
                {
                    string path = System.IO.Directory.GetCurrentDirectory();
                    path = path.Replace("\\UI\\bin\\Debug", "\\images\\empty_image.jpg");
                    food_image = Image.FromFile(path);
                }
                

                food_image = (Image)(new Bitmap(food_image, new Size(150, 125)));
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

            LoadData();
            CreateBillID();
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

        private void bt_cancelBill_Click(object sender, EventArgs e)
        {
            bill_list.Clear();
            LoadData();
            lb_offPrice.Text = "0";
            lb_finalPrice.Text = "0";
            textBox_moneyPay.Text = "0";
            textBox_voucher.Clear();
            CreateBillID();
        }

        private void LoadData()
        {
            DataTable dt = converter.ToDataTable(bill_list);
            dataGridView_bill.DataSource = dt;
            lb_totalPrice.Text = order_BLL.TotalBillPrice(bill_list).ToString();
            lb_totalAmount.Text = order_BLL.TotalProductAmount(bill_list).ToString();
            lb_finalPrice.Text = (Convert.ToInt32(lb_totalPrice.Text) - Convert.ToInt32(lb_offPrice.Text)).ToString();
            dataGridView_bill.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView_bill.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView_bill.Columns[2].HeaderText = "Giá tiền";
            dataGridView_bill.Columns[3].HeaderText = "Số lượng";
        }

        private void CreateBillID()
        {
            billid = "bill" + order_BLL.randID();
            while (true)
            {
                if (order_BLL.ChechNewBillID(billid))
                    break;
                billid = "bill" + order_BLL.randID();
            }
            lb_billID.Text = billid;
        }

        private void bt_checkVoucher_Click(object sender, EventArgs e)
        {
            VOUCHER voucher = new VOUCHER();
            if (textBox_voucher.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập voucher! Voucher mặc định: Khong");
            }
            else
            {
                voucher = order_BLL.CheckVoucher(textBox_voucher.Text);
                if (voucher == null)
                {
                    MessageBox.Show("Không tồn tại voucher!");
                }
                else if (voucher.apply_price > (Convert.ToDouble(lb_totalPrice.Text)))
                {
                    MessageBox.Show("Chưa đạt điều kiện!");
                }
                else
                {
                    if (voucher != null)
                    {
                        double off_value = (double)voucher.off_percent * (Convert.ToDouble(lb_totalPrice.Text)) / 100;
                        if (off_value >= voucher.max_money)
                        {
                            lb_offPrice.Text = (voucher.max_money).ToString();
                        }
                        else
                        {
                            lb_offPrice.Text = (off_value).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã không hợp lệ!");
                    }
                }
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox_moneyPay.TextLength == 0)
            {
                textBox_moneyPay.Text = "0";
            }

            string totalPrice = lb_totalPrice.Text;
            string offPrice = lb_offPrice.Text;
            string finalPrice = lb_finalPrice.Text;
            string moneyGet = textBox_moneyPay.Text;
            string moneyReturn = (Convert.ToInt32(textBox_moneyPay.Text) - Convert.ToInt32(lb_finalPrice.Text)).ToString();

            bool check = false;
            FinishOrder finishOrder = new FinishOrder();
            finishOrder.finalPrice = finalPrice;
            finishOrder.offPrice = offPrice;
            finishOrder.moneyGet = moneyGet;
            finishOrder.moneyReturn = moneyReturn;
            finishOrder.totalPrice = totalPrice;

            finishOrder.ShowDialog();

            check = finishOrder.check;

            if (check)
            {
                DataTable dt = converter.ToDataTable(bill_list);
                if (textBox_voucher.TextLength == 0)
                {
                    textBox_voucher.Text = "Khong";
                }
                bool check_2 = order_BLL.AddBill(billid, emp_id, textBox_voucher.Text, Int32.Parse(totalPrice), Int32.Parse(offPrice), Int32.Parse(finalPrice));
                bool check_3 = order_BLL.AddBillDetail(billid, dt);
                
                if (check_2 == true & check_3 == true)
                {
                    MessageBox.Show("Thanh toán thành công!");
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Đã huỷ thanh toán!");
            }
            CreateBillID();
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

        private void bt_exportBill_Click(object sender, EventArgs e)
        {
            EditBillTXT();
            string filename = "D:\\Bill_Export_Done.txt";
            //Create a StreamReader object  
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Consolas", 10, FontStyle.Bold);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
        }

        private void EditBillTXT()
        {
            string path = System.Environment.CurrentDirectory.ToString();
            path = path.Replace("\\UI\\bin\\Debug", "\\images\\Bill_Export.txt");
            string text = File.ReadAllText(path);



            text = text.Replace("(1)", DateTime.Now.ToString());
            text = text.Replace("(2)", lb_billID.Text);
            text = text.Replace("(3)", emp_name);
            text = text.Replace("(4)", emp_phone);
            foreach (var item in bill_list)
            {
                
                text = text.Replace("(5)","     " + PaddingForSpace(item.Product, 26) + PaddingForSpace(item.Amount.ToString(), 10) + item.Price + Environment.NewLine + "(5)");
            }
            text = text.Replace("(5)","");
            text = text.Replace("(6)", lb_totalAmount.Text);
            text = text.Replace("(7)", lb_totalPrice.Text);
            text = text.Replace("(8)", textBox_voucher.Text);
            text = text.Replace("(9)", lb_offPrice.Text);
            text = text.Replace("(10)", lb_finalPrice.Text);

            File.WriteAllText("D:\\Bill_Export_Done.txt", text);

        }

        private string PaddingForSpace(string word, int padding)
        {
            var si = new StringInfo(word);
            int num = padding - si.LengthInTextElements;
            for (int i = 0; i < num; i++)
                word = word + " ";
            return word;
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }
    }
}
