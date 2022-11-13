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
using System.Linq;
using BLL;
namespace UI
{
    public partial class ProductManage : Form
    {
        List<DAL.PRODUCT> productList = new List<DAL.PRODUCT>();
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
            productList = pro_BLL.getDataProductBLL();
            productData.DataSource = productList;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            productData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pic = (DataGridViewImageColumn)productData.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;


        }

        public void headerChange()
        {
            productData.Columns[0].HeaderText = "Mã sản phẩm";
            productData.Columns[1].HeaderText = "Tên sản phẩm";
            productData.Columns[2].HeaderText = "Hình ảnh";
            productData.Columns[3].HeaderText = "Giá tiền";
            productData.Columns[4].HeaderText = "Cập nhật vào";
            productData.Columns[5].HeaderText = "Chi tiết sản phẩm";
            productData.ReadOnly = true;
            //productData.DataSource = productList.OrderByDescending(x => x.product_id).ToList();

        }
        bool id_des = false;
        bool name_des = false;
        bool date_des = false;
        bool price_des = false;

        private void sort(int index)
        {
            
            
            if(index == 0)
            {
                if (id_des)
                {
                    id_des= false;
                    productData.DataSource = productList.OrderBy(x => x.product_id).ToList();
                }
                else
                {
                    id_des = true;
                    name_des = false;
                    date_des = false;
                    price_des = false;
                    productData.DataSource = productList.OrderByDescending(x => x.product_id).ToList();
                }
                
            }
            if(index == 1)
            {
                if (name_des)
                {
                    name_des = false;
                    productData.DataSource = productList.OrderBy(x => x.product_name).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = true;
                    date_des = false;
                    price_des = false;
                    productData.DataSource = productList.OrderByDescending(x => x.product_name).ToList();
                }
            }
            if(index == 4)
            {
                if (date_des)
                {
                    date_des = false;
                    productData.DataSource = productList.OrderBy(x => x.update_date).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = false;
                    date_des = true;
                    price_des = false;
                    productData.DataSource = productList.OrderByDescending(x => x.update_date).ToList();
                }
            }
            if(index == 3)
            {
                if (price_des)
                {
                    price_des = false;
                    productData.DataSource = productList.OrderBy(x => x.price).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = false;
                    date_des = false;
                    price_des = true;
                    productData.DataSource = productList.OrderByDescending(x => x.price).ToList();
                }
            }
            clearProductBinding();
            addProductBinding();
            //productData.ColumnHeaderMouseClick += DataGridViewCellMouseEventHandler(header_click);
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

        private void deleteData()
        {
            getValues();
            try
            {
                MessageBox.Show(pro_BLL.deleteProductBLL(id));
            }
            catch( Exception ex)
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
            deleteData();
            LoadData();
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
            productList = pro_BLL.searchProductBLL(searchName_Box.Text.TrimEnd());
            productData.DataSource = productList;//pro_BLL.searchProductBLL(searchName_Box.Text.TrimEnd());
            clearProductBinding();
            addProductBinding();
        }

        private void productData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sort(e.ColumnIndex);
        }
    }

}
