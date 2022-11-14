using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL emp_DAL = new EmployeeDAL();
        public List<EMPLOYEE> getDataBLL()
        {
            return emp_DAL.getDataEmpDAL();
        }

        public string addEmpBLL(string empName, byte[] empImg, string phone, DateTime doB, bool female, string position)
        {
            if (!checkAge(doB))
            {
                return "Không đủ tuổi";
            }
            else if (!checkPhone(phone))
            {
                return "Số điện thoại không hợp lệ \nSố phải có dạng:0XXXXXXXXX";
            }
            else if (emp_DAL.addEmpDAL(randID(), empName, empImg, phone, doB, female, position))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public EMPLOYEE InfoBLL(string hidname)
        {
            EMPLOYEE emp = new EMPLOYEE();
            emp = emp_DAL.getInfoDAL(hidname);
            return emp;
        }

        public string updateEmpBLL(string empID, string empName, byte[] empImg, string phone, DateTime doB, bool female, string position)
        {
            if (!checkAge(doB))
            {
                return "Không đủ tuổi";
            }
            else if (!checkPhone(phone))
            {
                return "Số điện thoại không hợp lệ \nSố phải có dạng:0XXXXXXXXX";
            }
            else if (emp_DAL.updateEmpDAL(empID, empName, empImg, phone, doB, female, position))
            {
                return "Cập nhật thành công";
            }
            else return "Thất bại";
        }

        public List<EMPLOYEE> searchEmployeeBLL(string empSearch)
        {
            List<EMPLOYEE> list = emp_DAL.getDataEmpDAL();
            List<EMPLOYEE> empList = new List<EMPLOYEE>();
            foreach(var e in list)
            {
                if(e.employee_name.ToLower().TrimEnd().Contains(empSearch.ToLower()))
                {
                    empList.Add(e);
                }
            }
            return empList;
        }

        bool checkPhone(string phone)
        {
            foreach(var c in phone)
            {
                if(!char.IsDigit(c))
                {
                    return false;
                }
            }
            if(!phone.StartsWith("0"))
            {
                return false;
            }    
            return true;
        }

        private string randID()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string ID = "";
            for (int i = 0; i < 10; i++)
            {
                char rand = chars[random.Next(0, chars.Length)];
                ID += rand;
            }
            return ID;
            
        }

        bool checkAge(DateTime birth)
        {
            if(birth.AddYears(18)>DateTime.Now)
            {
                return false;
            }    
            return true;
        }
    }
}
