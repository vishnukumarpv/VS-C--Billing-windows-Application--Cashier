using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_billing_concept
{
    class Item : the_billing_concept.Db.TheORM
    {
        public int id;
        public string name;
        public decimal amount;
        public decimal tax;
        public decimal taxed_amount;
        public decimal tax_perc_amount;
        public string currency = "";

        public Item()
        {
            table_ = "items";
            pk_ = "id";
            
/*
            this.id = 12;
            this.name = "This is sample";
            this.amount = 12.25m;
            this.tax = 5.00m;
            */

        }

        public int _id {
            get { return id;  }
            set { id = value; }
        }

        public string _name
        {
            get { return name;  }
            set { name = value;  }
        }

        public decimal _amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public decimal _tax
        {
            get { return tax; }
            set { tax = value; }
        }


        public void process()
        {
            tax_perc_amount = tax * (amount / 100);
            taxed_amount = amount + tax_perc_amount;
        }

 


 

        public string getItem(string req)
        {
            Console.WriteLine(req); 
            return req;
        }
        private decimal roundIt(decimal val)
        {
            return Math.Round(val, 2);
        }

    }
}
