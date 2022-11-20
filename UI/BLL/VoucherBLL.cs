using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class VoucherBLL
    {
        VoucherDAL vou_DAL = new VoucherDAL();
        public List<VOUCHER> getDataVoucherBLL()
        {
            return vou_DAL.getDataVoucherDAL();
        }

        public string addVoucherBLL(string id,string apply_price,string percent,string max_money)
        {
            int result;
            
            if (apply_price == "")
            {
                apply_price = "0";
            }
            if (percent == "")
            {
                percent = "0";
            }
            if (max_money == "")
            {
                max_money = "0";
            }
            if (!int.TryParse(apply_price, out result) || !int.TryParse(percent, out result) || !int.TryParse(max_money, out result))
            {
                return "Dữ liệu nhập sai kiểu";
            }
            int money = int.Parse(max_money);
            int price = int.Parse(apply_price);
            int per = int.Parse(percent);
            

            if (price < 0)
            {
                return "Giá sàn không hợp lệ";
            }
            else if (per < 0 || per > 50)
            {
                return "Phần trăm không đúng";
            }
            else if (money < 0)
            {
                return "Giá tối đa chưa hợp lệ";
            }
            else if (vou_DAL.addVoucherDAL(id, price, per, money))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public string updateVoucherBLL(string id, string apply_price, string percent, string max_money, bool used)
        {
            List<VOUCHER> list = vou_DAL.getDataVoucherDAL();
            if (list.Where(x => x.voucher_id == id).Count()==0)
            {
                return "Mã không tồn tại";
            }
            int result;

            if (apply_price == "")
            {
                apply_price = "0";
            }
            if (percent == "")
            {
                percent = "0";
            }
            if (max_money == "")
            {
                max_money = "0";
            }
            
            if (!int.TryParse(apply_price, out result) || !int.TryParse(percent, out result) || !int.TryParse(max_money, out result))
            {
                return "Dữ liệu nhập sai kiểu";
            }

            int money = int.Parse(max_money);
            int price = int.Parse(apply_price);
            int per = int.Parse(percent);


            if (price < 0)
            {
                return "Giá sàn không hợp lệ";
            }
            else if (per < 0 || per > 50)
            {
                return "Phần trăm không đúng";
            }
            else if (money < 0)
            {
                return "Giá tối đa chưa hợp lệ";
            }
            else if (vou_DAL.updateVoucherDAL(id, price, per, money,used))
            {
                return "Thành công";
            }
            else return "Thất bại";
        }

        public bool delVoucherBLL(string id)
        {
            List<VOUCHER> list = vou_DAL.getDataVoucherDAL();
            if (list.Where(x => x.voucher_id == id).Count() == 0)
            {
                return false;
            }

            return vou_DAL.DelVoucherDAL(id);
        }

        public List<VOUCHER> searchVoucher(string id)
        {
            List<VOUCHER> list = vou_DAL.getDataVoucherDAL();
            List<VOUCHER> data = new List<VOUCHER>();
            foreach(var voucher in list)
            {
                if (voucher.voucher_id.ToLower().Contains(id.ToLower().TrimEnd()))
                {
                    data.Add(voucher);
                }
            }
            return data;
     
        }
    }

    
}
