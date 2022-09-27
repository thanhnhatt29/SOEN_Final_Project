using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
namespace UI
{
    public partial class ProductManage : Form
    {
        ProductBLL pro_BLL = new ProductBLL();
        public ProductManage()
        {
            InitializeComponent();
            getData();

        }
        #region
        public void getData()
        {
            productData.DataSource = pro_BLL.getDataBLL();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            productData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pic = (DataGridViewImageColumn)productData.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        string id;
        string name;
        byte[] img;
        int price;
        string detail;

        public void getValues()
        {
            id = productID_Box.Text;
            name = productName_Box.Text;
            img = imageToArray(productImg);
            price = Int32.Parse(productPrice_box.Text);
            detail = productDetail.Text;

        }

        private void insertData()
        {
            getValues();
            try
            {
                pro_BLL.addProductBLL(name, img, price, detail);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
            
        }

        private byte[] imageToArray(PictureBox img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Image.Save(memoryStream, img.Image.RawFormat);
            return memoryStream.ToArray();
        }



        #endregion

        private void add_Button_Click(object sender, EventArgs e)
        {
            insertData();
            getData();
        }

        private void update_Button_Click(object sender, EventArgs e)
        {

        }

        private void remove_Button_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void productImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                productImg.ImageLocation = openFileDialog.FileName;
            }
        }
    }

}
