using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.Admin
{
    
    public partial class AddAccount : Form
    {
        AccountBLL accountBLL = new AccountBLL();
        public AddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = accountBLL.addAccountBLL(emp_Box.Text,passw_Box.Text,passw_reBox.Text,adminCheck.Checked);
            MessageBox.Show(message);
            if (message.Equals("Thêm tài khoản thành công"))
            {
                this.Close();
            }
        }

    }
}
