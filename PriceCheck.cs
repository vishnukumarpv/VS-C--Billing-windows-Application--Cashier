using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_billing_concept
{
    public partial class PriceCheck : UserControl
    {
        public PriceCheck()
        {
            InitializeComponent();

        }

        private void PriceCheck_Load(object sender, EventArgs e)
        {

        }

        private void findProduct(object sender, EventArgs e)
        {
            string item_text = item_textbox.Text;
            string currency = Properties.Settings.Default["currency"].ToString();


            int itemCode = Int32.Parse(item_text );
            if(item_text.Length < 1)
            {
                return;
            }

            Item item = new Item();
            item = (Item)item.find(itemCode);
             
            if (item.name == null)
            {
                item_name.Text = "Item not found";
                MessageBox.Show("Item Not found");
                return;
            }
            item_name.Text = item.name;
            item_price.Text = currency + item.amount.ToString();

        }
    }
}
