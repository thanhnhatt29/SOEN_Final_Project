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

namespace UI
{
    public partial class Login : Form
    {
        AccountBLL acc_BLL = new AccountBLL();
        Message message = new Message();

        public Login()
        {
            InitializeComponent();
            passw_Box.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        // Login button
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool success = acc_BLL.loginBLL(empId_Box.Text, passw_Box.Text);
            if(success)
            {
                
                this.Hide();
                DashBoard dashBoard = new DashBoard();
                message.Notify("Đã đăng nhập thành công");
                dashBoard.hiddenName = empId_Box.Text;
                dashBoard.ShowDialog();
                this.Show();
                passw_Box.Clear();
                
            }    
            else
            {
                MessageBox.Show("Thông tin đăng nhập chưa chính xác");
            }    
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassw.Checked)
            {
                passw_Box.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                passw_Box.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void passw_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Password pass = new Password();
            pass.ShowDialog();
            this.Show();
            passw_Box.Clear();
        }
    }
}
