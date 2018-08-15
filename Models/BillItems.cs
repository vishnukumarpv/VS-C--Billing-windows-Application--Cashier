using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_billing_concept.Models
{
    class BillItems: the_billing_concept.Db.TheORM
    {
        private int item_id;
        private int bill_id;
        private int qty;
        private decimal price;
        private bool voided;

        public int _item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }

        public decimal _price
        {
            get { return price; }
            set { price = value; }
        }
        public int _qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public int _bill_id
        {
            get { return bill_id; }
            set { bill_id = value; }
        }

        public BillItems()
        {
            table_ = "bill_items";
            pk_ = "id";
        }
    }
}
