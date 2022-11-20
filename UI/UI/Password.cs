using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace UI
{
    public partial class Password : Form
    {
        AccountBLL acc_BLL = new AccountBLL();
        public Password()
        {
            InitializeComponent();
            this.AcceptButton = buttonConfirm;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                EMPLOYEE emp = db.EMPLOYEEs.Find(empId_Box.Text);
                ACCOUNT account = db.ACCOUNTs.Find(empId_Box.Text);
                if(account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại","Cảnh báo");
                }
                else if(emp.phone_number == phone_Box.Text)
                {
                    MessageBox.Show("Mật khẩu của bạn là "+account.passwd,"Mật khẩu");
                }
                
            }
        }
    }
}
