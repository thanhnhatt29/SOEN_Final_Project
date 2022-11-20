using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class AccountDAL
    {
        public List<ACCOUNT> getDataAccDAL()
        {
            List<ACCOUNT> data = new List<ACCOUNT>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.ACCOUNTs
                            select c;
                foreach(var acc in table)
                {
                    data.Add(acc);
                }    
                return data;
            }    
        }

        public ACCOUNT loginDAL(string name)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var acc = from c in db.ACCOUNTs
                          where c.employee_id == name
                          select c;
                foreach (var a in acc)
                {
                   return a;
                }    
                return null;
            }
          
        }

        public bool addAccountDAL(string id, string passw, bool admin)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                ACCOUNT acc = new ACCOUNT();

                acc.employee_id = id;
                acc.passwd = passw;
                acc.permission = admin;

                try
                {
                    db.ACCOUNTs.Add(acc);
                    db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                
                return true;
            }
        }

        public List<ACCOUNT> FindAccDAL(string name)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                string filter = ConvertToUnSign(name);
                var query = db.ACCOUNTs.Where(delegate (ACCOUNT c)
                {
                    if (ConvertToUnSign(c.employee_id).IndexOf(filter, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        return true;
                    else
                        return false;
                }).AsQueryable();
                return query.ToList();
            }
        }
        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }

        public bool DelAccountDAL(string id_del)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                try
                {
                    ACCOUNT result = db.ACCOUNTs.Where(i => i.employee_id == id_del).SingleOrDefault();
                    if (result != null)
                    {
                        db.ACCOUNTs.Remove(result);
                        db.SaveChanges();
                    }
                    return true;
                }
                catch
                { return false; }
            }
        }
    }
}
