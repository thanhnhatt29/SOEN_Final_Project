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
    public partial class EmployeeManage : Form
    {
        EmployeeBLL emp_BLL = new EmployeeBLL();
        public EmployeeManage()
        {
            InitializeComponent();
            LoadData();

        }

        #region
        void LoadData()
        {
            clearEmpBinding();
            getData();
            addEmpBinding();
            headerChange();
        }

        void getData()
        {
            empData.DataSource = emp_BLL.getDataBLL();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            empData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pic = (DataGridViewImageColumn)empData.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        void headerChange()
        {
            empData.Columns[0].HeaderText = "ID";
            empData.Columns[1].HeaderText = "Name";
            empData.Columns[2].HeaderText = "Image";
            empData.Columns[3].HeaderText = "Phone";
            empData.Columns[4].HeaderText = "Date of birth";
            empData.Columns[5].HeaderText = "Female";
            empData.Columns[6].HeaderText = "Position";
        }
        string id;
        string name;
        byte[] img;
        string phone;
        DateTime doB;
        bool female;
        string position;

        void getValues()
        {
            id = empID_Box.Text;
            name = empName_Box.Text;
            img = null;
            if(empImg.Image != null)
            {
                img = imageToArray(empImg);
            }

            phone = empPhone_Box.Text;
            doB = empBirth.Value;
            female = empFemale.Checked;
            position = empPos_Box.Text;
        }

        void addEmpBinding()
        {
            empID_Box.DataBindings.Add(new Binding("Text", empData.DataSource, "employee_id", true,DataSourceUpdateMode.Never));
            empName_Box.DataBindings.Add(new Binding("Text", empData.DataSource, "employee_name", true, DataSourceUpdateMode.Never));
            empImg.DataBindings.Add(new Binding("Image", empData.DataSource, "employee_img", true, DataSourceUpdateMode.Never));
            empPhone_Box.DataBindings.Add(new Binding("Text", empData.DataSource, "phone_number", true, DataSourceUpdateMode.Never));
            empBirth.DataBindings.Add(new Binding("Value", empData.DataSource, "birth", true, DataSourceUpdateMode.Never));
            empFemale.DataBindings.Add(new Binding("Checked", empData.DataSource, "gender", true, DataSourceUpdateMode.Never));
            empPos_Box.DataBindings.Add(new Binding("Text", empData.DataSource, "position", true, DataSourceUpdateMode.Never));
        }

        void clearEmpBinding()
        {
            empID_Box.DataBindings.Clear();
            empName_Box.DataBindings.Clear();
            empImg.DataBindings.Clear();
            empPhone_Box.DataBindings.Clear();
            empBirth.DataBindings.Clear();
            empFemale.DataBindings.Clear();
            empPos_Box.DataBindings.Clear();
        }

        private byte[] imageToArray(PictureBox img)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (img != null)
            {
                img.Image.Save(memoryStream, img.Image.RawFormat);
            }

            return memoryStream.ToArray();
        }
        void insertData()
        {
            getValues();
            try
            {
                MessageBox.Show(emp_BLL.addEmpBLL(name,img,phone,doB,female,position));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
            
        }

        void updateData()
        {
            getValues();
            try
            {
                MessageBox.Show(emp_BLL.updateEmpBLL(id,name,img, phone,doB,female,position));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }

        void deleteData()
        {
            getValues();
            try
            {
                MessageBox.Show(emp_BLL.updateEmpBLL(id, name, img, phone, doB, female, "Đã nghỉ")+" nhân viên nghỉ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }
        #endregion

        private void searchName_Box_TextChanged(object sender, EventArgs e)
        {
            empData.DataSource = emp_BLL.searchEmployeeBLL(searchName_Box.Text.TrimEnd());
            clearEmpBinding();
            addEmpBinding();
        }

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
            searchName_Box.Clear();
            LoadData();
        }

        private void empImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                empImg.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
