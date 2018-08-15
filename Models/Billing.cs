using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_billing_concept.Models
{
    class Billing : the_billing_concept.Db.TheORM
    {
  
        //private int item_id;
        private int qty;
        private decimal total;

 
        /*
        public int _item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }
        */
        public int _qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public decimal _total
        {
            get { return total; }
            set { total = value; }
        }

        public Billing()
        {
            table_ = "bills";
            pk_ = "id";
        }
    }
}
