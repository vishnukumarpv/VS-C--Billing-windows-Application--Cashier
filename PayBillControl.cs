using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace the_billing_concept
{
    public partial class PayBillControl : UserControl
    { 
        public string p_number;
        private TextBox focussed_tbox, defa_textbox;
        public decimal _total { get; set; }
        private decimal user_inp = 0.0m;
        private decimal user_atm = 0.0m;
        private decimal bal = 0.0m;
        private string currency = Properties.Settings.Default["currency"].ToString();

        public decimal bill_total { get; set; }

        public DataGridView bills_datagrid { get; set; }

        public Form payForm;

        public void setForm(Form form)
        {
            this.payForm = form; 
        }

        public PayBillControl()
        {
            InitializeComponent();
            defa_textbox = amount_cash;

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
        public void setTotal()
        {
            total_show.Text = currency + _total.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.payForm.Close();
        }

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            decimal inp;
            NumberStyles styles;
            CultureInfo culture;
            styles = NumberStyles.Integer | NumberStyles.AllowDecimalPoint;
            culture = CultureInfo.CreateSpecificCulture("en-GB");

            var textboxStr = (sender as TextBox).Text;
            bool res = Decimal.TryParse(textboxStr,styles, culture, out inp);

            if (!res)
            {
                MessageBox.Show("yep :"+ textboxStr);
               // (sender as TextBox).Text = Decimal.Parse(textboxStr).ToString();
                return;
            }

    
        }



        private void paymentKeyEntered(object sender, EventArgs e)
        {
            string inpu = (sender as TextBox).Text;
 
 
            user_inp =  Decimal.Parse(inpu);
            bal = _total - (user_inp + user_atm);
            bal_label.Text = bal.ToString(); 
        }

        private void cashViaAtmTextChange(object sender, EventArgs e)
        {
            string inpu = (sender as TextBox).Text;
            user_atm = Decimal.Parse(inpu);
            bal = _total - (user_inp + user_atm);

            bal_label.Text = bal.ToString();
 
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(this.bal > 0)
            {
                MessageBox.Show("Cant save. pay the full amount");
                return;
            }



            the_billing_concept.Models.Billing bill;
            the_billing_concept.Models.BillItems bill_items;

            bill = new the_billing_concept.Models.Billing();

            bill._total = this.bill_total;
            int bill_id = bill.create();

            DataGridViewRowCollection bills;
            bills = bills_datagrid.Rows;

            Console.WriteLine("id :"+bill_id);
             

            List<object> items = new List<object>();

            bill_items = new Models.BillItems();

            for (int i = 0; i < bills.Count - 1; i++)
            {
                bill_items = new Models.BillItems();
                bill_items._bill_id = bill_id;
                bill_items._item_id = (int)bills[i].Cells[1].Value;
                bill_items._qty = (int)bills[i].Cells[3].Value;
                bill_items._price = (decimal)bills[i].Cells[6].Value;

                items.Add(bill_items);
            }

            bill_items.create(items);

            /*BillingHome bh = new BillingHome();
            BillingControl bc = new BillingControl();
            bc.billing_completed = true;
            bc.billCompleated();
            */
           // ((total_show)BillingControl).Text = "done";




        }

        private void cancel_Click(object sender, EventArgs e)
        {
             
        }

        private void numberPadClear(object sender, EventArgs e)
        {
            this.user_inp = 0;
            this.user_atm = 0;
            focussed_tbox.Text = "0";
            this.p_number = null;
        }

        private void numberPad(object sender, EventArgs e)
        {
            var btn_string = (sender as Button).Text;
 
            p_number = p_number + btn_string;
            

            if (focussed_tbox == null)
            {
                focussed_tbox = defa_textbox;
            }


            focussed_tbox.Text = p_number;
            focussed_tbox.Focus();
        }
    }
}
