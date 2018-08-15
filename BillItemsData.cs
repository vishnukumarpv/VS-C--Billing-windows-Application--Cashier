using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_billing_concept
{
    class BillItemsData
    {
        public int slno { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public int qty { get; set; }
        public decimal rate { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }

    }
}
