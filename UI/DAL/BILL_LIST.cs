using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class BILL_LIST
    {
        public string ID { get; set; }
        public string Product { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }
    }
}
