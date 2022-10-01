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


        void LoadData()
        {
            getData();
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
    }
}
