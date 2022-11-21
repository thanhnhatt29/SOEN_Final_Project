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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AcceptButton = Confirm_bt;
        }

        public void Notify(string message)
        {
            label2.Text = message;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
