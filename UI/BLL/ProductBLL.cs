using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        ProductDAL pro_DAL = new ProductDAL();
        public List<PRODUCT> getDataBLL()
        {
            DataTable dt = new DataTable();
            List<PRODUCT> data = pro_DAL.getDataDAL();
            foreach (PRODUCT item in data)
            {
                dt.Rows.Add(item);
            }

            //return dt;
            return pro_DAL.getDataDAL();
        }

        public bool addProductBLL(string productName, byte[] productImg, int productPrice, string details)
        {
            return pro_DAL.addProductDAL(productName, productImg, productPrice, details);
        }
    }
}
