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
        public string hiddenname;
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
            LoadData();
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
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản này?", "Xoá tài khoản", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (acc_BLL.DelAccountBLL(id_del, hiddenname))
                {
                    MessageBox.Show("Xoá tài khoản thành công");
                    //Load();
                }
                else
                {
                    MessageBox.Show("Không thể xoá!");
                }
            }
            LoadData();
        }

        private void bt_capquyen_Click(object sender, EventArgs e)
        {
            string id_set = accData.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn có muốn cấp quyền quản trị cho tài khoản này?", "Cấp quyền", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (acc_BLL.SetAdminBLL(id_set))
                {
                    MessageBox.Show("Cấp quyền tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            LoadData();
        }


        private void accData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (accData.CurrentRow.Cells[2].Value.ToString().Equals("True"))
            {
                bt_capquyen.Enabled = false;
            }
            else bt_capquyen.Enabled = true;
        }
    }
}
