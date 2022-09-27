using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        public List<PRODUCT> getDataDAL()
        {
            List<PRODUCT> data = new List<PRODUCT>();
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                var table = from c in db.PRODUCTs
                            select c;
                foreach (var product in table)
                {
                    data.Add(product);
                }
                return data;
            }

        }

        public bool addProductDAL(string productName, byte[] productImg, int productPrice, string details)
        {
            using (FASTFOODEntities db = new FASTFOODEntities())
            {
                PRODUCT product = new PRODUCT();

                product.product_name = productName;
                product.product_img = productImg;
                product.price = productPrice;
                product.detail = details;
                product.update_date = DateTime.Now;

                db.PRODUCTs.Add(product);
                db.SaveChanges();
                return true;
            }

        }
    }
}
