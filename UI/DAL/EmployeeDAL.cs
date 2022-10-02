using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        public List<EMPLOYEE> getDataEmpDAL()
        {
            List<EMPLOYEE> data = new List<EMPLOYEE>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.EMPLOYEEs
                            select c;
                foreach(var emp in table)
                {
                    data.Add(emp);
                }    
                return data;
            }    
        }

        public bool updateEmpDAL(string empID, string empName, byte[] empImg, string phone, DateTime doB, bool female, string position)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.EMPLOYEEs
                            select c;
                foreach (var t in table)
                {
                    if(t.employee_id == empID)
                    {
                        t.employee_name = empName;
                        t.employee_img = empImg;
                        t.phone_number = phone;
                        t.birth = doB;
                        t.gender = female;
                        t.position = position;
                    }
                    
                }
                db.SaveChanges();
                return true;
            }
        }

        public bool addEmpDAL(string empID,string empName,byte[] empImg, string phone, DateTime doB, bool female, string position)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                EMPLOYEE emp = new EMPLOYEE();

                emp.employee_id = empID;
                emp.employee_name = empName;
                emp.employee_img = empImg;
                emp.phone_number = phone;
                emp.birth = doB;
                emp.gender = female;
                emp.position = position;

                db.EMPLOYEEs.Add(emp);
                db.SaveChanges();
                return true;
            }

           
        }
    }
}
