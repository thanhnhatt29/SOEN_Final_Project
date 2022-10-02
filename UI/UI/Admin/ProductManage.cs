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
            LoadData();
            

        }
        #region
        public void LoadData()
        {
            clearProductBinding();
            getData();
            addProductBinding();
            headerChange();
        }
        public void getData()
        {
            productData.DataSource = pro_BLL.getDataProductBLL();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            productData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pic = (DataGridViewImageColumn)productData.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        public void headerChange()
        {
            productData.Columns[0].HeaderText = "ID";
            productData.Columns[1].HeaderText = "Name";
            productData.Columns[2].HeaderText = "Image";
            productData.Columns[3].HeaderText = "Price";
            productData.Columns[4].HeaderText = "Last Updated";
            productData.Columns[5].HeaderText = "Details";
        }
        int id;
        string name;
        byte[] img;
        int price;
        string detail;

        public void getValues()
        {
            id = Int32.Parse(productID_Box.Text);
            name = productName_Box.Text;
            img = null;
            if(productImg.Image!=null)
            {
                img = imageToArray(productImg);
            }    
            
            price = Int32.Parse(productPrice_box.Text);
            detail = productDetail.Text;

        }

        private void insertData()
        {
            getValues();
            try
            {
                MessageBox.Show(pro_BLL.addProductBLL(name, img, price, detail));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
            
        }

        private void updateData()
        {
            getValues();
            try
            {
                
                MessageBox.Show(pro_BLL.updateProductBLL(id, name, img, price, detail));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }

        private byte[] imageToArray(PictureBox img)
        {
            MemoryStream memoryStream = new MemoryStream();
            if(img != null)
            {
                img.Image.Save(memoryStream, img.Image.RawFormat);
            }    
            
            return memoryStream.ToArray();
        }

        void addProductBinding()
        {
            
            productID_Box.DataBindings.Add(new Binding("Text", productData.DataSource, "product_id",true,DataSourceUpdateMode.Never));
            productName_Box.DataBindings.Add(new Binding("Text",productData.DataSource, "product_name", true, DataSourceUpdateMode.Never));
            productImg.DataBindings.Add(new Binding("Image", productData.DataSource, "product_img", true, DataSourceUpdateMode.Never));
            productPrice_box.DataBindings.Add(new Binding("Text", productData.DataSource, "price", true, DataSourceUpdateMode.Never));
            productDetail.DataBindings.Add(new Binding("Text", productData.DataSource, "detail", true, DataSourceUpdateMode.Never));
        }
        void clearProductBinding()
        {
            productID_Box.DataBindings.Clear();
            productName_Box.DataBindings.Clear();
            productImg.DataBindings.Clear();
            productPrice_box.DataBindings.Clear();
            productDetail.DataBindings.Clear();
        }

        void disableButton()
        {
            add_Button.Enabled = false;
            update_Button.Enabled = false;
        }



        #endregion

        private void add_Button_Click(object sender, EventArgs e)
        {
            insertData();
            LoadData();
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            updateData();
            LoadData();
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            //clearProductBinding();
            searchName_Box.Clear();
            LoadData();
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

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //addProductBinding();
        }

        private void searchName_Box_TextChanged(object sender, EventArgs e)
        {
            productData.DataSource = pro_BLL.searchProductBLL(searchName_Box.Text.TrimEnd());
            clearProductBinding();
            addProductBinding();
        }
    }

}
