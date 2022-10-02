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
    }
}
