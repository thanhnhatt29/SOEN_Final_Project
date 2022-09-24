using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        // Order button
        private void order_button_Click(object sender, EventArgs e)
        {
            OrderManage orderManage = new OrderManage() { Dock = DockStyle.Fill, TopLevel = false };
            orderManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dashboard_panel.Controls.Add(orderManage);
            orderManage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}
