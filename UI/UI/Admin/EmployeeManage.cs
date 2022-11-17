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
        List<DAL.EMPLOYEE> empList = new List<DAL.EMPLOYEE>();
        EmployeeBLL emp_BLL = new EmployeeBLL();
        AccountBLL accountBLL = new AccountBLL();
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
            empList = emp_BLL.getDataBLL();
            empData.DataSource = empList;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            empData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pic = (DataGridViewImageColumn)empData.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        void headerChange()
        {
            empData.Columns[0].HeaderText = "Mã nhân viên";
            empData.Columns[1].HeaderText = "Tên nhân viên";
            empData.Columns[2].HeaderText = "Ảnh";
            empData.Columns[3].HeaderText = "Số điện thoại";
            empData.Columns[4].HeaderText = "Ngày sinh";
            empData.Columns[5].HeaderText = "Nữ";
            empData.Columns[5].Width = 30;
            empData.Columns[6].HeaderText = "Công việc";
            empData.ReadOnly = true;

            empData.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        bool id_des = false;
        bool name_des = false;
        bool doB_des = false;
        bool gender_des = false;

        private void sort(int index)
        {
            if(index == 0)
            {
                if (id_des)
                {
                    id_des = false;
                    empData.DataSource = empList.OrderBy(x=>x.employee_id).ToList();
                }
                else
                {
                    id_des = true;
                    name_des = false;
                    doB_des = false;
                    gender_des = false;
                    empData.DataSource = empList.OrderByDescending(x=>x.employee_id).ToList();
                }
            }
            if(index == 1)
            {
                if (name_des)
                {
                    name_des = false;
                    empData.DataSource = empList.OrderBy(x => x.employee_name).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = true;
                    doB_des = false;
                    gender_des = false;
                    empData.DataSource = empList.OrderByDescending(x => x.employee_name).ToList();
                }
            }
            if(index == 4)
            {
                if (doB_des)
                {
                    doB_des = false;
                    empData.DataSource = empList.OrderBy(x => x.birth).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = false;
                    doB_des = true;
                    gender_des = false;
                    empData.DataSource = empList.OrderByDescending(x => x.birth).ToList();
                }
            }
            if(index == 5)
            {
                if (gender_des)
                {
                    gender_des = false;
                    empData.DataSource = empList.OrderBy(x => x.gender).ToList();
                }
                else
                {
                    id_des = false;
                    name_des = false;
                    doB_des = false;
                    gender_des = true;
                    empData.DataSource = empList.OrderByDescending(x => x.gender).ToList();
                }
            }

            clearEmpBinding();
            addEmpBinding();
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
                
                if (accountBLL.DelAccountBLL(id))
                {
                    MessageBox.Show(emp_BLL.updateEmpBLL(id, name, img, phone, doB, female, "Đã nghỉ") + " nhân viên nghỉ.");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }
        #endregion

        private void searchName_Box_TextChanged(object sender, EventArgs e)
        {
            empList = emp_BLL.searchEmployeeBLL(searchName_Box.Text.TrimEnd());
            empData.DataSource = empList;
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

        private void empData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sort(e.ColumnIndex);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
