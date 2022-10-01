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
        public List<PRODUCT> getDataProductBLL()
        {
            /*DataTable dt = new DataTable();
            List<PRODUCT> data = pro_DAL.getDataDAL();
            foreach (PRODUCT item in data)
            {
                dt.Rows.Add(item);
            }*/

            //return dt;
            return pro_DAL.getDataProductDAL();
        }

        public string addProductBLL(string productName, byte[] productImg, int productPrice, string details)
        {
            if(!checkMoney(productPrice))
            {
                return "Tiền không hợp lệ";
            }
            if (pro_DAL.addProductDAL(productName, productImg, productPrice, details))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public string updateProductBLL(int productID,string productName, byte[] productImg, int productPrice, string details)
        {
            if (!checkMoney(productPrice))
            {
                return "Tiền không hợp lệ";
            }
            if(pro_DAL.updateProductDAL(productID, productName, productImg, productPrice, details))
            {
                return "Thành công";
            }    
            else return "Thất bại";
        }

        public List<PRODUCT> searchProductBLL(string productSearch)
        {
            List<PRODUCT> list = pro_DAL.getDataProductDAL();
            List<PRODUCT> productList = new List<PRODUCT>();
            foreach(var p in list)
            {
                if(p.product_name.ToLower().TrimEnd().Contains(productSearch.ToLower()))
                {
                    productList.Add(p);
                }    
            }   
            return productList;
        }
        bool checkMoney(int money)
        {
            if(money < 0 || money % 1000!=0)
            {
                return false;
            }    
            return true;
        }
    }
}
