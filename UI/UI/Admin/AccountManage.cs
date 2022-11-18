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
            accData.Columns[0].HeaderText = "Mã nhân viên";
            accData.Columns[1].HeaderText = "Mật khẩu";
            accData.Columns[2].HeaderText = "Quản trị viên";
            accData.ReadOnly = true;
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }



        private void tx_findAcc_TextChanged(object sender, EventArgs e)
        {
            if (tx_findAcc.Text != null)
            {
                accData.DataSource = acc_BLL.FindAccBLL(tx_findAcc.Text);
            }
            else
            {
                getData();
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string id_del = accData.CurrentRow.Cells[0].Value.ToString();
            if (acc_BLL.DelAccountBLL(id_del))
            {
                MessageBox.Show("Xoá tài khoản thành công");
                //Load();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
