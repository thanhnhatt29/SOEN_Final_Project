using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class AccountBLL
    {
        AccountDAL acc_DAL = new AccountDAL();
        public List<ACCOUNT> getDataAccBLL()
        {
            return acc_DAL.getDataAccDAL();
        }

        public bool loginBLL(string name, string passw)
        {
            if(name == "" || passw == "")
            {
                return false;
            }   
            else
            {
                ACCOUNT acc = acc_DAL.loginDAL(name);
                if (acc == null)
                {
                    return false;
                }
                else if (acc.passwd.TrimEnd() == passw.TrimEnd())
                {
                    return true;
                }

                return false;
            }               

        }

        public string addAccountBLL(string id, string passw, string passw_re,bool admin)
        {
            if (passw != passw_re)
            {
                return "Mật khẩu nhập lại chưa chính xác";
            }
            else
            {
                bool success = acc_DAL.addAccountDAL(id,passw,admin);
                if(success)
                    return "Thêm tài khoản thành công";
                return "Thất bại";
            }
        }

        public List<ACCOUNT> FindAccBLL(string name)
        {
            return acc_DAL.FindAccDAL(name);
        }

        public bool DelAccountBLL(string id_del)
        {
            return acc_DAL.DelAccountDAL(id_del);
        }
    }
}
