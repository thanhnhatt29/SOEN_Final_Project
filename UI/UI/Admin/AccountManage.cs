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
    public partial class AccountManage : Form
    {
        AccountBLL acc_BLL = new AccountBLL();
        public AccountManage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            getData();
        }

        public void getData()
        {
            accData.DataSource = acc_BLL.getDataAccBLL();
            accData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }
    }
}
