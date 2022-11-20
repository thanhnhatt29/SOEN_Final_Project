using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Admin;
using BLL;
using DAL;

namespace UI
{
    public partial class DashBoard : Form
    {
        public string hiddenName;
        public DashBoard()
        {
            InitializeComponent();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            order_button.PerformClick();
            lb_greet.Text = "Chào " + GetUserName(hiddenName) + " <3"; //sau khi set lại form login thì phải uncomment dòng này

        }
        public string GetUserName(string hidname)
        {
            //EmployeeBLL emp_BLL = new EmployeeBLL();
            //EMPLOYEE Info = emp_BLL.InfoBLL(hiddenName);
            //return Info.employee_name.TrimEnd();

            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                ACCOUNT acc = db.ACCOUNTs.Find(hiddenName);
                EMPLOYEE emp = db.EMPLOYEEs.Find(hiddenName);
                
                if (acc.permission==false)
                {
                    voucher_button.Enabled = false;
                    revenue_button.Enabled = false;
                    account_button.Enabled = false;
                    employee_button.Enabled = false;
                    product_button.Enabled = false;
                }
                return emp.employee_name.TrimEnd();
            }
        }

        
        public void ClearColorButton()
        {
            order_button.BackColor = default(Color);
            voucher_button.BackColor = default(Color);
            product_button.BackColor = default(Color);  
            employee_button.BackColor = default(Color);
            account_button.BackColor = default(Color);  
            revenue_button.BackColor = default(Color);
            selling_button .BackColor = default(Color);
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Tạo Đơn Hàng";
            OrderManage orderManage = new OrderManage() { Dock = DockStyle.Fill, TopLevel = false };
            orderManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(orderManage);
            orderManage.emp_id = hiddenName;
            orderManage.Show();
            ClearColorButton();
            order_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }
        
        private void voucher_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Quản lý Mã giảm giá";
            VoucherManage voucherManage = new VoucherManage() { Dock = DockStyle.Fill, TopLevel = false };
            voucherManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(voucherManage);
            voucherManage.Show();
            ClearColorButton();
            voucher_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Quản lý Sản phẩm";
            ProductManage productManage = new ProductManage() { Dock = DockStyle.Fill, TopLevel = false };
            productManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(productManage);
            productManage.Show();
            ClearColorButton();
            product_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Quản lý nhân viên";
            EmployeeManage employeeManage = new EmployeeManage() { Dock = DockStyle.Fill, TopLevel = false };
            employeeManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(employeeManage);
            employeeManage.Show();
            ClearColorButton();
            employee_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Quản lý tài khoản";
            AccountManage accountManage = new AccountManage() { Dock = DockStyle.Fill, TopLevel = false };
            accountManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(accountManage);
            accountManage.Show();
            ClearColorButton();
            account_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void revenue_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Doanh thu";
            RevenueManage revenueManage = new RevenueManage() { Dock = DockStyle.Fill, TopLevel = false };
            revenueManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(revenueManage);
            revenueManage.Show();
            ClearColorButton();
            revenue_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void selling_button_Click(object sender, EventArgs e)
        {
            lb_nameForm.Text = "Quản lý bán hàng";
            SellingHistory sellingHistory = new SellingHistory() { Dock = DockStyle.Fill, TopLevel = false };
            sellingHistory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(sellingHistory);
            sellingHistory.Show();
            ClearColorButton();
            selling_button.BackColor = System.Drawing.SystemColors.HotTrack;
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
