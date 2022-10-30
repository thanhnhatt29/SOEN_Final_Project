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
    }
}
