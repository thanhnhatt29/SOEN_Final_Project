using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherDAL
    {
        public List<VOUCHER> getDataVoucherDAL()
        {
            List<VOUCHER> data = new List<VOUCHER>();
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.VOUCHERs
                            select c;
                foreach(VOUCHER voucher in table)
                {
                    data.Add(voucher);
                }
                return data;
            }
        }

        public bool addVoucherDAL(string id,int apply_price,int percent,int max_money)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                VOUCHER voucher = new VOUCHER();

                voucher.voucher_id= id;
                voucher.apply_price= apply_price;
                voucher.off_percent= percent;
                if (max_money == 0)
                {
                    voucher.max_money = null;
                }
                else
                {
                    voucher.max_money = max_money;
                }
                voucher.used = false;

                db.VOUCHERs.Add(voucher);
                db.SaveChanges();
                return true;
            }
        }
        public bool updateVoucherDAL(string id, int apply_price, int percent, int max_money,bool used)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                VOUCHER voucher = db.VOUCHERs.Where(x => x.voucher_id.TrimEnd() == id).SingleOrDefault();

                
                voucher.apply_price = apply_price;
                voucher.off_percent = percent;
                if (max_money == 0)
                {
                    voucher.max_money = null;
                }
                else
                {
                    voucher.max_money = max_money;
                }
                voucher.used = used;

                
                db.SaveChanges();
                return true;
            }
        }
        public bool DelVoucherDAL(string id)
        {
            using(FASTFOODEntities db = new FASTFOODEntities())
            {
                try
                {
                    VOUCHER voucher = db.VOUCHERs.Where(x=>x.voucher_id.TrimEnd()==id).SingleOrDefault();
                    if(voucher != null)
                    {
                        db.VOUCHERs.Remove(voucher);
                        db.SaveChanges();
                        
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
