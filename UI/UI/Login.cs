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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        // Login button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashBoard = new DashBoard();
            dashBoard.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
