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

namespace UI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            OrderManage orderManage = new OrderManage() { Dock = DockStyle.Fill, TopLevel = false };
            orderManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(orderManage);
            orderManage.Show();
        }
        
        private void order_button_Click(object sender, EventArgs e)
        {
            OrderManage orderManage = new OrderManage() { Dock = DockStyle.Fill, TopLevel = false };
            orderManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(orderManage);
            orderManage.Show();
        }
        
        private void voucher_button_Click(object sender, EventArgs e)
        {
            VoucherManage voucherManage = new VoucherManage() { Dock = DockStyle.Fill, TopLevel = false };
            voucherManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(voucherManage);
            voucherManage.Show();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            ProductManage productManage = new ProductManage() { Dock = DockStyle.Fill, TopLevel = false };
            productManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(productManage);
            productManage.Show();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            EmployeeManage employeeManage = new EmployeeManage() { Dock = DockStyle.Fill, TopLevel = false };
            employeeManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(employeeManage);
            employeeManage.Show();
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            AccountManage accountManage = new AccountManage() { Dock = DockStyle.Fill, TopLevel = false };
            accountManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(accountManage);
            accountManage.Show();
        }

        private void revenue_button_Click(object sender, EventArgs e)
        {
            RevenueManage revenueManage = new RevenueManage() { Dock = DockStyle.Fill, TopLevel = false };
            revenueManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(revenueManage);
            revenueManage.Show();
        }

        private void selling_button_Click(object sender, EventArgs e)
        {
            SellingHistory sellingHistory = new SellingHistory() { Dock = DockStyle.Fill, TopLevel = false };
            sellingHistory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(sellingHistory);
            sellingHistory.Show();
        }
    }
}
