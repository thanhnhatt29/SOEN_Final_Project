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

namespace UI.Employee
{
    public partial class ChangePassword : Form
    {
        AccountBLL accountBLL = new AccountBLL();
        public string hiddenname;
        public ChangePassword()
        {
            InitializeComponent();
            currentPW_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            passw_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            retype_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
            string message = accountBLL.ChangePasswordBLL(hiddenname, currentPW_tb.Text, passw_tb.Text, retype_tb.Text);
            MessageBox.Show(message);
            if (message.Equals("Đổi mật khẩu thành công!"))
            {
                this.Close();
            }
        }

        private void showPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassw.Checked)
            {
                currentPW_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                passw_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                retype_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                currentPW_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                passw_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                retype_tb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
