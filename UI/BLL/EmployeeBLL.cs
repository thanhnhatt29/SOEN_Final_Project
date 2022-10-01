using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
