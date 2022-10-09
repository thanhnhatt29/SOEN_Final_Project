using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class OrderBLL
    {
        OrderDAL order_DAL = new OrderDAL();
        public List<PRODUCT> GetDataProduct()
        {
            return order_DAL.getDataProduct();
        }
    }
}
