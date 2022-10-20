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
    public partial class FinishOrder : Form
    {
        public bool check = false;
        public string totalPrice;
        public string offPrice;
        public string finalPrice;
        public string moneyGet;
        public string moneyReturn;

        public FinishOrder()
        {
            InitializeComponent();
        }

        private void FinishOrder_Load(object sender, EventArgs e)
        {
            lb_totalPrice.Text = totalPrice;
            lb_offPrice.Text = offPrice;
            lb_finalPrice.Text = finalPrice;
            lb_moneyGet.Text = moneyGet;
            lb_moneyReturn.Text = moneyReturn;
        }

        private void bt_yes_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }
    }
}
