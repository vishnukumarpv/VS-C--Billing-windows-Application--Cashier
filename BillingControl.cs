using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using the_billing_concept.Db;

// using MySql.Data.MySqlClient;

namespace the_billing_concept
{
    public partial class BillingControl : UserControl
    {
        private string p_number = "";
        private TextBox focussed_tbox = null;
        private decimal bill_total = 0.00m;
        private decimal total_tax = 0.00m;
        public bool billed { get; set; }
        private int items_count = 0;
        private string currency_ind = "$";

        private List<BillItemsData> _items;


        public BillingControl()
        {
            InitializeComponent();

            _items = new List<BillItemsData>();
        }

        private void numberpadPressed(object sender, EventArgs e)
        {
            p_number = p_number + (sender as Button).Text;
            if(focussed_tbox == null)
            {
                focussed_tbox = item_textbox;
            } 


            focussed_tbox.Text = p_number;
            focussed_tbox.Focus();

        }

        private void clearInput(object sender, EventArgs e)
        {
            p_number = null;
            qty_textbox.Text = "1";
            item_textbox.Text = null;
            item_textbox.Focus();


        }

        private void eTextBox(object sender, EventArgs e)
        {
            if (focussed_tbox != (sender as TextBox))
            {
                p_number = null;
            }
            focussed_tbox = (sender as TextBox);
            // focussed_tbox.SelectAll();

        }

        private void itemAddToBills(object sender, EventArgs e)
        {
            string item_text = item_textbox.Text;
            item_textbox.Focus();

            if (item_text.Length < 1)
            {
                return;
            }

            // ValidATE THIS******
            int item_qty = 0 ;
            
            decimal item_total_price = 0.00m;

            Item item = new Item();
            item = (Item)item.find( Int32.Parse(item_text) ); 

            p_number = null;
            

            if (item.name == null)
            {
                MessageBox.Show("Item not found");
                return;
            }
            item_textbox.Text = null;


            item.process();
            Console.WriteLine("tax " + item.amount);

            item_qty = Int32.Parse(qty_textbox.Text);

            item_total_price = item.taxed_amount* item_qty; 
            items_count++;
              
         bills_datagrid.Rows.Add(
                    items_count,
                    item.id,
                    item.name, item_qty,
                    item.amount, Math.Round( item.tax_perc_amount, 2 ), 
                    Math.Round( item_total_price, 2 )
         );


            total_tax = total_tax + (item.tax_perc_amount * item_qty);

            bill_total = bill_total + item_total_price;
            bill_total = Math.Round(bill_total, 2);
            decimal[] total_dec = this.decimalProcess(bill_total);

            bill_total = total_dec[0];
            total_show.Text = currency_ind+" " + bill_total.ToString();
            rounded_show.Text = currency_ind+" " +total_dec[1].ToString();
            tax_show.Text = currency_ind+" " + total_tax.ToString();

        }


        private void processBilling(object sender, EventArgs e)
        {
            int bill_id;
            if (this.bill_total == 0 )
            {
                MessageBox.Show("Bill something");
                return;
            }
            PayBillsForm py = new PayBillsForm(this.bill_total);
            py.ShowDialog();
            return;

             

            the_billing_concept.Models.Billing bill;
            the_billing_concept.Models.BillItems bill_items;

            bill = new the_billing_concept.Models.Billing();

            bill._total = bill_total; 
            bill_id = bill.create();

            DataGridViewRowCollection bills;
            bills = bills_datagrid.Rows;

            Console.WriteLine("b : "+bills);

            List<object> items = new List<object>();

            bill_items = new Models.BillItems();
             
            for (int i=0; i < bills.Count - 1; i++)
            { 
                bill_items = new Models.BillItems();
                bill_items._bill_id = bill_id;
                bill_items._item_id = (int)bills[i].Cells[1].Value; 
                bill_items._qty = (int)bills[i].Cells[3].Value;
                bill_items._price = (decimal)bills[i].Cells[6].Value;

                items.Add(bill_items); 
            }

            bill_items.create(items);
             


        }

        private void resetAll()
        {
            

            bills_datagrid.DataSource = _items;
            total_show.Text = currency_ind + " 0";
            rounded_show.Text = currency_ind + " 0";
            tax_show.Text = currency_ind + " 0";

        p_number = "";
        focussed_tbox = null;
        bill_total = 0.00m;
        total_tax = 0.00m; 
        items_count = 0;
    }


        private decimal[] decimalProcess(decimal val)
        {
            decimal res, after, finaly;
            after = 0.00m;
            int intVal = (int)val;
            res = val - intVal;
            if (res < 0.20m)
            {
                after = 0.00m;
            }
            else if (res > 0.20m && res < 0.34m)
            {
                after = 0.25m;
            }
            else if (res > 0.35m && res < 0.64m)
            {
                after = 0.50m;
            }
            else if (res > 0.65m && res < 0.84m)
            {
                after = 0.75m;
            }
            else if (res > 0.85m && res < 0.99m)
            {
                after = 1.00m;
            }

            finaly = intVal + after;
            decimal[] result = new decimal[] { finaly, after };
            return result;
        }

        private void cellClicked(object sender, DataGridViewCellEventArgs e)
        { 
            int rowIndex = e.RowIndex; 
            DialogResult confirm = MessageBox.Show(
                "Are you sure to delete this item?",
                "verify it is the mostin",
                MessageBoxButtons.YesNoCancel
                );

            if(confirm == DialogResult.Yes)
            {
                
            }

        }
    }

}


